using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class MusicController : MonoBehaviour {
    public static MusicController instanc;

    AudioSource audioSource;

    void Awake() {
        MakeSingleton();
        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {

    }

    public void PlayMusic(bool play) {
        if (play) {
            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
        }
        else {
            if (audioSource.isPlaying) {
                audioSource.Stop();
            }
        }
    }
    void MakeSingleton() {
        if (instanc != null) {
            Destroy(this);
        }
        else {
            instanc = this;
            DontDestroyOnLoad(this);
        }
    }
}
