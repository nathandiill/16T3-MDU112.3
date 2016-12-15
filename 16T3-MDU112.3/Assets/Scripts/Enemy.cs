using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float sceneDelay = 3.0f;
    private bool delayActive = false;

    void OnCollisionEnter2D (Collision2D other)
    {
        delayActive = true;
        Update();
        SoundManager.Instance.enemyAudio();
    }

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
