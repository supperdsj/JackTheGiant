using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    float speed = 1f;
    float acceleration = .2f;
    float maxSpeed = 3.2f;

    [HideInInspector] public bool moveCamera;

    void Start() {
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
