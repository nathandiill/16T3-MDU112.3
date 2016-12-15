using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public float deathTimeRemaining = 2f;
    public GameObject enemyPrefab;

    void OnCollisionEnter2D (Collision2D other)
    {
        SoundManager.Instance.impactAudio();
    }

    void Start()
    {
	
	}
	
	void Update()
    {
        deathTimeRemaining -= Time.deltaTime;
        
        if (deathTimeRemaining <= 0)
        {
            Destroy(gameObject);
        }
    }
	
}
