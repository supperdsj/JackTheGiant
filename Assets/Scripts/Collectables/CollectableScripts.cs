using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScripts : MonoBehaviour
{
    void OnEnable() {
        Invoke("DestroyCollectable",6f);
    }

    void OnDisable() {

    }

    void OnDestroyCollectable() {
        gameObject.SetActive(false);
    }
}
