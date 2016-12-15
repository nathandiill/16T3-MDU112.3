using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public virtual void OnCollisionEnter2D (Collision2D other)
    {
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
