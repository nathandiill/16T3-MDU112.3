using UnityEngine;
using System.Collections;

public class RedGate : Gate
{
    public Collider2D redCollider;

    void RedKeyPickedUp()
    {
        redCollider = gameObject.GetComponent<Collider2D>();

        redCollider.enabled = false;
    }
}
