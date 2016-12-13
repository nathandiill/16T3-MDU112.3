using UnityEngine;
using System.Collections;

public class RedGate : Gate
{
    public Collider2D redCollider;

    void RedKeyPickedUp()
    {
        redCollider = gameObject.GetComponent<Collider2D>();

        redCollider.enabled = false;
        GameManager.Instance.CurrentXP(1, GameManager.Instance.currentXP);
    }

    public Collider2D yellowCollider;

    void YellowKeyPickedUp()
    {
        yellowCollider = gameObject.GetComponent<Collider2D>();

        yellowCollider.enabled = true;
    }

    public Collider2D blueCollider;

    void BlueKeyPickedUp()
    {
        blueCollider = gameObject.GetComponent<Collider2D>();

        blueCollider.enabled = true;
    }
}
