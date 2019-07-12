using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour {
    public static GameManagerController instace;
    [HideInInspector] public bool gameStartedFromMainMenu, gameRestartedAfterPlayerDied;
    [HideInInspector] int score, coinScore, lifeScore;

    void Awake() {
        MakerSingleton();
    }

    void Start() {
        InitializeVariables();
    }

    void MakerSingleton() {
        if (instace == null) {
            instace = this;
            DontDestroyOnLoad(this);
        }
        else {
            Destroy(this);
        }
    }

    void OnEnable() {
        SceneManager.sceneLoaded += LevelFinishedLoading;
    }

    void OnDisable() {
        SceneManager.sceneLoaded -= LevelFinishedLoading;
    }

    void LevelFinishedLoading(Scene scene, LoadSceneMode mode) {
        switch (scene.name) {
            case "Gameplay":
                if (gameRestartedAfterPlayerDied) {
                    GameplayController.instance.SetScore(score);
                    GameplayController.instance.SetCoinScore(coinScore);
                    GameplayController.instance.SetLifeScore(lifeScore);
                    PlayerScore.scoreCount = score;
                    PlayerScore.coinCount = coinScore;
                    PlayerScore.lifeCount = lifeScore;
                }
                else if (gameStartedFromMainMenu) {
                    GameplayController.instance.SetScore(0);
                    GameplayController.instance.SetCoinScore(0);
                    GameplayController.instance.SetLifeScore(2);
                    PlayerScore.scoreCount = 0;
                    PlayerScore.coinCount = 0;
                    PlayerScore.lifeCount = 2;
                }

                break;
        }
    }

    void InitializeVariables() {
        print("InitializeVariables");
        if (!PlayerPrefs.HasKey("GameInitialized")) {
            GamePreferences.SetEasyDifficultyState(0);
            GamePreferences.SetEasyDifficultyCoinScore(0);
            GamePreferences.SetEasyDifficultyScore(0);

            GamePreferences.SetMediumDifficultyState(1);
            GamePreferences.SetMediumDifficultyCoinScore(0);
            GamePreferences.SetMediumDifficultyScore(0);

            GamePreferences.SetHardDifficultyState(0);
            GamePreferences.SetHardDifficultyCoinScore(0);
            GamePreferences.SetHardDifficultyScore(0);

            GamePreferences.SetMusicState(0);
            PlayerPrefs.SetInt("GameInitialized", 1);
            print("Init game");
        }
    }

    public void CheckGameStatus(int score, int coinScore, int lifeScore) {
        if (lifeScore < 0) {
            if (GamePreferences.GetEasyDifficultyState() == 1) {
                int scoreNow = GamePreferences.GetEasyDifficultyScore();
                int coinScoreNow = GamePreferences.GetEasyDifficultyCoinScore();
                if (scoreNow < score) {
                    GamePreferences.SetEasyDifficultyScore(score);
                }

                if (coinScoreNow < coinScore) {
                    GamePreferences.SetEasyDifficultyCoinScore(coinScore);
                }
            }
            else if (GamePreferences.GetMediumDifficultyState() == 1) {
                int scoreNow = GamePreferences.GetMediumDifficultyScore();
                int coinScoreNow = GamePreferences.GetMediumDifficultyCoinScore();
                if (scoreNow < score) {
                    GamePreferences.SetMediumDifficultyScore(score);
                }

                if (coinScoreNow < coinScore) {
                    GamePreferences.SetMediumDifficultyCoinScore(coinScore);
                }
            }
            else if (GamePreferences.GetHardDifficultyState() == 1) {
                int scoreNow = GamePreferences.GetHardDifficultyScore();
                int coinScoreNow = GamePreferences.GetHardDifficultyCoinScore();
                if (scoreNow < score) {
                    GamePreferences.SetHardDifficultyScore(score);
                }

                if (coinScoreNow < coinScore) {
                    GamePreferences.SetHardDifficultyCoinScore(coinScore);
                }
            }

            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDied = false;
            GameplayController.instance.ShowGameoverPanel(score, coinScore);
        }
        else {
            this.score = score;
            this.coinScore = coinScore;
            this.lifeScore = lifeScore;
            GameplayController.instance.SetScore(score);
            GameplayController.instance.SetCoinScore(coinScore);
            GameplayController.instance.SetLifeScore(lifeScore);
            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDied = true;
            GameplayController.instance.PlayerDiedRestartTheGame();
        }
    }
}
