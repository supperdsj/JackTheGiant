﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawner : MonoBehaviour {
    public GameObject[] backgrounds;
    public float lastY;

    void Start() {
        GetBackgroundsAndSetLastY();
    }

    void GetBackgroundsAndSetLastY() {
        backgrounds = GameObject.FindGameObjectsWithTag("Background");
        lastY = backgrounds[0].transform.position.y;
        for (int i = 1; i < backgrounds.Length; i++) {
            if (backgrounds[i].transform.position.y < lastY) {
                lastY = backgrounds[i].transform.position.y;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Background") {
            if (target.transform.position.y == lastY) {
                print("trigger");
                Vector3 temp = target.transform.position;
                float height = ((BoxCollider2D)target).size.y;
                print(height);
                for (int i = 0; i < backgrounds.Length; i++) {
                    if (!backgrounds[i].activeInHierarchy) {
                        temp.y -= height;
                        lastY = temp.y;
                        backgrounds[i].transform.position = temp;
                        backgrounds[i].SetActive(true);
                    }
                }
            }
        }
    }
}
