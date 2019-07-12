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

    public void CheckGameStatus(int score, int coinScore, int lifeScore) {
        if (lifeScore < 0) {
            gameStartedFromMainMenu = false;
            gameRestartedAfterPlayerDied = false;
            GameplayController.instance.ShowGameoverPanel(score,coinScore);
        }
        else {
            this.score= score;
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
