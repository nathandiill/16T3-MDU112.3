using UnityEngine;
using System.Collections;

public class SpeedPickUp : PickUp
{
    // On collision apply boost and destroy
    public override void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        Speed();
        
        SoundManager.Instance.speedAudio();
    }

    public float Speed()
    {
        PlayerController.Instance.movementSpeed = PlayerController.Instance.movementSpeed + 5f;
        return PlayerController.Instance.movementSpeed;
    }
}
