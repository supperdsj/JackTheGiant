using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class PlayerScore : MonoBehaviour {
    [SerializeField] AudioClip coinClip, lifeClip;

    [SerializeField] CameraScript cameraScript;

    Vector3 previousPosition;

    bool countScore;

    public static int scoreCount=1, lifeCount=1, coinCount=1;

    void Awake() {
        cameraScript = Camera.main.GetComponent<CameraScript>();
    }

    // Start is called before the first frame update
    void Start() {
        previousPosition = transform.position;
        countScore = true;
    }

    void CountScore() {
        if (countScore) {
            if (transform.position.y < previousPosition.y) {
                scoreCount++;
            }
            previousPosition = transform.position;
            GameplayController.instance.SetScore(scoreCount);
        }
    }

    void OnTriggerEnter2D(Collider2D target) {
        switch (target.tag) {
            case "Coin":
                coinCount++;
                scoreCount += 200;
                GameplayController.instance.SetScore(scoreCount);
                GameplayController.instance.SetCoinScore(coinCount);
                AudioSource.PlayClipAtPoint(coinClip, transform.position);
                target.gameObject.SetActive(false);
                break;
            case "Life":
                lifeCount++;
                scoreCount += 300;
                GameplayController.instance.SetScore(scoreCount);
                GameplayController.instance.SetLifeScore(lifeCount);
                AudioSource.PlayClipAtPoint(lifeClip, transform.position);
                target.gameObject.SetActive(false);
                break;
            case "Bounds":
            case "Deadly":
                // if (lifeCount <= 0) {
                transform.position = new Vector3(500, 500, 0);
                countScore = false;
                cameraScript.moveCamera = false;
                lifeCount--;
                GameManagerController.instace.CheckGameStatus(scoreCount,coinCount,lifeCount);
                // }
                break;
        }
    }

    // Update is called once per frame
    void Update() {
        CountScore();
    }
}
