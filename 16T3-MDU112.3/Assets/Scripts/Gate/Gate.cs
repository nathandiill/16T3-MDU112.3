using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour
{
    private SpriteRenderer sr;
    
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }
	
	void Update()
    {
        	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        // Retrieve the other objects spiter renderer
        SpriteRenderer otherSR = other.gameObject.GetComponent<SpriteRenderer>();
    }
}
