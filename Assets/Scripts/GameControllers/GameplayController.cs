using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {
    public static GameplayController instance;

    [SerializeField] Text scoreText, coinText, lifeText;
    [SerializeField] GameObject pausePanel;

    void Awake() {
        MakeInstance();
    }

    void MakeInstance() {
        if (instance == null) {
            instance = this;
        }
    }

    public void SetScore(int score) {
        scoreText.text = "x" + score;
    }

    public void SetCoinScore(int coinScore) {
        coinText.text = "x" + coinScore;
    }

    public void SetLifeScore(int lifeScore) {
        lifeText.text = "x" + lifeScore;
    }

    public void PauseTheGame() {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void ResumeGame() {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void QuitGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
