using UnityEngine;
using System.Collections;

public class YellowGate : Gate
{
    public Collider2D yellowCollider;
  
    // If yellowkey is active, disable collider
    void YellowKeyPickedUp()
    {
        yellowCollider = gameObject.GetComponent<Collider2D>();
        
        yellowCollider.enabled = false;
        GameManager.Instance.CurrentXP(1, GameManager.Instance.currentXP);
    }

    public Collider2D blueCollider;

    // If bluekey is active, enable collider
    void BlueKeyPickedUp()
    {
        blueCollider = gameObject.GetComponent<Collider2D>();

        blueCollider.enabled = true;
    }

    public Collider2D redCollider;

    // If redkey is active, enable collider
    void RedKeyPickedUp()
    {
        redCollider = gameObject.GetComponent<Collider2D>();

        redCollider.enabled = true;
    }
}
