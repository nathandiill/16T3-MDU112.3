using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    // Destroy pickup on collision
    public virtual void OnCollisionEnter2D (Collision2D other)
    {
        Destroy(gameObject);
    }
}
