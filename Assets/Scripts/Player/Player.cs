﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 4f;
    public float maxVelocity = 8f;

    Rigidbody2D myBody;
    Animator anim;

    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void FixedUpdate() {
        PlayerMoveKeyboard();
    }

    void PlayerMoveKeyboard() {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);
        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0) {
            if (vel < maxVelocity) {
                forceX = speed;
                Vector3 temp = transform.localScale;
                temp.x = 1f;
                transform.localScale = temp;
                anim.SetBool("Walk", true);
            }
        }
        else if (h < 0) {
            if (vel < maxVelocity) {
                forceX = -speed;
                Vector3 temp = transform.localScale;
                temp.x = -1f;
                transform.localScale = temp;
                anim.SetBool("Walk", true);
            }
        }
        else {
            anim.SetBool("Walk", false
            );
        }

        myBody.AddForce(new Vector2(forceX, 0));
    }
}
