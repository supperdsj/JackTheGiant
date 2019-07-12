using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {
    public static GameplayController instance;

    [SerializeField] Text scoreText, coinText, lifeText;
    [SerializeField] Text gameoverScoreText, gameoverCoinText;
    [SerializeField] GameObject pausePanel,gameoverPanel;
    [SerializeField] GameObject readyButton;
    void Awake() {
        MakeInstance();
    }

    void Start() {
        Time.timeScale = 0;
        readyButton.SetActive(true);
    }

    public void StartTheGame() {
        Time.timeScale = 1;
        readyButton.SetActive(false);
    }
    void MakeInstance() {
        if (instance == null) {
            instance = this;
        }
    }

    public void ShowGameoverPanel(int finalScore, int finalCoinScore) {
        gameoverPanel.SetActive(true);
        gameoverCoinText.text = "x" + finalCoinScore;
        gameoverScoreText.text = "x" + finalScore;
        StartCoroutine(LoadGameoverMainMenu());
    }

    IEnumerator LoadGameoverMainMenu() {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayerDiedRestartTheGame() {
        StartCoroutine(PlayerDiedRestart());
    }
    IEnumerator PlayerDiedRestart() {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Gameplay");

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
