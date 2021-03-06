﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public float sceneDelay = 3.0f;
    private bool delayActive = false;

    // On collision activate delay and play victory sound
    void OnCollisionEnter2D(Collision2D other)
    {
        delayActive = true;
        Update();
        SoundManager.Instance.victoryAudio();
    }

    void Update()
    {
        if (delayActive)
        {
            sceneDelay -= Time.deltaTime;

            if (sceneDelay <= 0)
            {
                delayActive = false;
                SceneManager.LoadScene(2);
            }
        }
    }
}
