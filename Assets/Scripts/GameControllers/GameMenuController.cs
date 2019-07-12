﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour {
    public void StartGame() {
        GameManagerController.instace.gameStartedFromMainMenu = true;
        GameManagerController.instace.gameRestartedAfterPlayerDied = false;
        SceneManager.LoadScene("Gameplay");
    }

    public void HighScoreMenu() {
        SceneManager.LoadScene("HighScoreMenu");
    }

    public void OptionsMenu() {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame() {
        Application.Quit();
    }

    public void MusicButton() {

    }
}
