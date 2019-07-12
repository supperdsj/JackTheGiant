using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {
    [SerializeField] AudioClip coinClip, lifeClip;

    [SerializeField] CameraScript cameraScript;

    Vector3 previousPosition;

    bool countScore;

    public static int scoreCount, lifeCount, coinCount;

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
                previousPosition = transform.position;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target) {
        switch (target.tag) {
            case "Coin":
                coinCount++;
                scoreCount += 200;
                AudioSource.PlayClipAtPoint(coinClip, transform.position);
                target.gameObject.SetActive(false);
                break;
            case "Life":
                lifeCount++;
                scoreCount += 300;
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
                // }
                break;
        }
    }

    // Update is called once per frame
    void Update() {
    }
}
