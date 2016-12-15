using UnityEngine;
using System.Collections;

public class RedKey : Key
{
    public string RedKeyPickedUp;
    public GameObject[] Gates;

    // Find objects with gate tag
    void OnTriggerEnter2D(Collider2D other)
    {
        Gates = GameObject.FindGameObjectsWithTag("Gate");
        foreach (GameObject Gate in Gates)
        {
            // Foreach gate let them know the red key was taken
            Gate.SendMessage("RedKeyPickedUp", SendMessageOptions.DontRequireReceiver);
        }

        SoundManager.Instance.redKeyAudio();
    }
}
