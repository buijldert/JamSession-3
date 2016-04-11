﻿using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour {

    public static float speed2;

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed2);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector2.right * speed2);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed2);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector2.up * speed2);
        }



    }
}