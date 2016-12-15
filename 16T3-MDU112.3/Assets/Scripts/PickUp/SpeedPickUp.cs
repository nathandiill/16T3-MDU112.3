using UnityEngine;
using System.Collections;

public class SpeedPickUp : PickUp
{
    // On collision apply boost and destroy
    public override void OnCollisionEnter2D(Collision2D other)
    {
        PlayerController.Instance.movementSpeed = 10.0f;
        Destroy(gameObject);

        SoundManager.Instance.speedAudio();
    }
}
