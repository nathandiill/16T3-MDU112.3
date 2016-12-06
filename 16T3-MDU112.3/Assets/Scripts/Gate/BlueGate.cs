using UnityEngine;
using System.Collections;

public class BlueGate : Gate
{
    public Collider2D blueCollider;

    void BlueKeyPickedUp()
    {
        blueCollider = gameObject.GetComponent<Collider2D>();

        blueCollider.enabled = false;
    }
}
