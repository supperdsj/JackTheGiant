using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreMenuController : MonoBehaviour {
    GameplayController gc;

    void Start() {
        gc = GameObject.Find("GameplayController").GetComponent<GameplayController>();
    }

    public void GoBackButton() {
        SceneManager.LoadScene("MainMenu");
    }

}
