using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    float speed = 1f;
    float acceleration = .2f;
    float maxSpeed = 3.2f;

    float easySpeed = 3.5f;
    float mediumSpeed = 4f;
    float hardSpeed = 4.5f;

    [HideInInspector] public bool moveCamera;

    void Start() {
        if (GamePreferences.GetEasyDifficultyState() == 1) {
            maxSpeed = easySpeed;
        }else if (GamePreferences.GetMediumDifficultyState() == 1) {
            maxSpeed = mediumSpeed;
        }else if (GamePreferences.GetHardDifficultyState() == 1) {
            maxSpeed = hardSpeed;
        }
        moveCamera = true;
    }

    void Update() {
        if (moveCamera) {
            MoveCamera();
        }
    }

    void MoveCamera() {
        Vector3 temp = transform.position;
        float oldY = temp.y;
        float newY = temp.y - (speed * Time.deltaTime);
        temp.y = Mathf.Clamp(temp.y, oldY, newY);
        transform.position = temp;
        speed += acceleration * Time.deltaTime;
        if (speed > maxSpeed) {
            speed = maxSpeed;
        }
    }
}
