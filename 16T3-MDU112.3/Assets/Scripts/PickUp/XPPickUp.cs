using UnityEngine;
using System.Collections;

public class XPPickUp : PickUp
{
    // On collision apply XP to player
    public override void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.Instance.CurrentXP(1);
        Destroy(gameObject);

        SoundManager.Instance.XPAudio();
    }
}
