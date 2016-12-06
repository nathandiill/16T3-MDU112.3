using UnityEngine;
using System.Collections;

public class YellowGate : Gate
{
    public Collider2D yellowCollider;
  
    void YellowKeyPickedUp()
    {
        yellowCollider = gameObject.GetComponent<Collider2D>();
        
        yellowCollider.enabled = false;
    }

    public Collider2D blueCollider;

    void BlueKeyPickedUp()
    {
        blueCollider = gameObject.GetComponent<Collider2D>();

        blueCollider.enabled = true;
    }
}
