using UnityEngine;
using System.Collections;

public class RedGate : Gate
{
    public Collider2D redCollider;

    // If redkey is active, disable collider
    void RedKeyPickedUp()
    {
        redCollider = gameObject.GetComponent<Collider2D>();

        redCollider.enabled = false;
        GameManager.Instance.CurrentXP(1);
    }

    public Collider2D yellowCollider;

    // If yellowkey is active, enable collider
    void YellowKeyPickedUp()
    {
        yellowCollider = gameObject.GetComponent<Collider2D>();

        yellowCollider.enabled = true;
    }

    public Collider2D blueCollider;

    // If bluekey is active, enable collider
    void BlueKeyPickedUp()
    {
        blueCollider = gameObject.GetComponent<Collider2D>();

        blueCollider.enabled = true;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.Instance.CurrentXP(1);
    }
}
