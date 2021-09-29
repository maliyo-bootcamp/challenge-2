﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public bool gameOver = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        } else if (gameOver)
        {
            Debug.Log("Game Over!");
        }
       
    }
}
