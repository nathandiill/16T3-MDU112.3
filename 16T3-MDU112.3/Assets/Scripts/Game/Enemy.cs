﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float sceneDelay = 3.0f;
    private bool delayActive = false;

    // If enemy is touched reload scene to reset player
    void OnCollisionEnter2D (Collision2D other)
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            delayActive = true;
            Update();
            SoundManager.Instance.enemyAudio();
        }
        else if (GameObject.FindGameObjectWithTag("Projectile"))
        {
            Destroy(gameObject);
        }              
    }

    // Timer in update
	void Update()
    {
        if(delayActive)
        {
            sceneDelay -= Time.deltaTime;

            if (sceneDelay <= 0)
            {
                delayActive = false;
                SceneManager.LoadScene(1);
            }
        }
	}
}
