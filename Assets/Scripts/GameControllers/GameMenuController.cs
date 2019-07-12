using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenuController : MonoBehaviour {
    [SerializeField] Button musicButton;
    [SerializeField] Sprite[] musicIcons;

    void CheckToPlayTheMusic() {
        if (GamePreferences.GetMusicState() == 1) {
            MusicController.instanc.PlayMusic(true);
            musicButton.image.sprite = musicIcons[1];
        }
        else {
            MusicController.instanc.PlayMusic(false);
            musicButton.image.sprite = musicIcons[0];
        }
    }

    void Start() {
        CheckToPlayTheMusic();
    }

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
        if (GamePreferences.GetMusicState() == 0) {
            GamePreferences.SetMusicState(1);
        }
        else {
            GamePreferences.SetMusicState(0);
        }
        CheckToPlayTheMusic();
    }
}
