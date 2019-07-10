using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour {
    float minX;
    float maxX;

    void Start() {
        SetMinAndMaxX();
    }

    void Update() {
        if (transform.position.x < minX) {
            Vector3 temp = transform.position;
            temp.x = minX;
            transform.position=temp;
        }else if (transform.position.x > maxX) {
            Vector3 temp = transform.position;
            temp.x = maxX;
            transform.position=temp;
        }
    }

    void SetMinAndMaxX() {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        maxX = bounds.x;
        minX = -bounds.x;
    }
}
