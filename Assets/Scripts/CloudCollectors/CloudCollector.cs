using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollector : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D target) {
        print(target.tag);
        if (target.tag == "Cloud" || target.tag == "Deadly") {
            target.gameObject.SetActive(false);
        }
    }
}
