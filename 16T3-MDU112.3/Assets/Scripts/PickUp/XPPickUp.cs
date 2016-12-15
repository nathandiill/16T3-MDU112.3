using UnityEngine;
using System.Collections;

public class XPPickUp : PickUp
{
    public override void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.Instance.CurrentXP(1, GameManager.Instance.currentXP);
        Destroy(gameObject);
    }
}
