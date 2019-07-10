using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CloudSpawner : MonoBehaviour {
    [SerializeField] GameObject[] clouds;
    float distanceBetweenClouds = 3f;
    float minX, maxX;
    float lastCloudPosY;
    float controlX;
    [SerializeField] GameObject[] collectables;
    [SerializeField] GameObject player;

    void Awake() {
        controlX = 0;
        SetMinAndMaxX();
        CreateClouds();
    }

    void SetMinAndMaxX() {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        print(bounds);
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
        print(minX);
        print(maxX);
    }

    void Shuffle(GameObject[] arrayToShuffle) {
        for (int i = 0; i < arrayToShuffle.Length; i++) {
            int random = Random.Range(i, arrayToShuffle.Length);
            GameObject temp = arrayToShuffle[i];
            arrayToShuffle[i] = arrayToShuffle[random];
            arrayToShuffle[random] = temp;
        }
    }

    void CreateClouds() {
        Shuffle(clouds);
        float positionY = 0f;
        for (int i = 0; i < clouds.Length; i++) {
            Vector3 temp = clouds[i].transform.position;
            temp.y = positionY;
            if (controlX == 0) {
                temp.x = Random.Range(0.0f, maxX);
                controlX = 1;
            }else if (controlX == 1) {
                temp.x = Random.Range(0.0f, minX);
                controlX = 2;
            }else if (controlX == 2) {
                temp.x = Random.Range(1.0f, maxX);
                controlX = 3;
            }else if (controlX == 3) {
                temp.x = Random.Range(-1.0f,minX);
                controlX = 0;
            }
            lastCloudPosY = positionY;
            clouds[i].transform.position = temp;
            positionY -= distanceBetweenClouds;
        }
    }
}
