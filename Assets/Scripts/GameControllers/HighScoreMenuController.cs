using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreMenuController : MonoBehaviour {

    [SerializeField] Text scoreText, coinText;
    public void GoBackButton() {
        SceneManager.LoadScene("MainMenu");
    }

    void Start() {
        SetScoreBasicOnDifficulty();
    }

    void SetScore(int score, int coinScore) {
        scoreText.text = score.ToString();
        coinText.text = coinScore.ToString();
    }

    void SetScoreBasicOnDifficulty() {
        if (GamePreferences.GetEasyDifficultyState() == 1) {
            SetScore(GamePreferences.GetEasyDifficultyScore(),GamePreferences.GetEasyDifficultyCoinScore());
        }
        if (GamePreferences.GetMediumDifficultyState() == 1) {
            SetScore(GamePreferences.GetMediumDifficultyScore(), GamePreferences.GetMediumDifficultyCoinScore());
        }
        if (GamePreferences.GetHardDifficultyState() == 1) {
            SetScore(GamePreferences.GetHardDifficultyScore(),GamePreferences.GetHardDifficultyCoinScore());
        }
    }

}
