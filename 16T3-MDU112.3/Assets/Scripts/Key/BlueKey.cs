using UnityEngine;
using System.Collections;

public class BlueKey : Key
{
    public string BlueKeyPickedUp;
    public GameObject[] Gates;

    // Find objects with gate tag
    void OnTriggerEnter2D(Collider2D other)
    {
        Gates = GameObject.FindGameObjectsWithTag("Gate");
        foreach (GameObject Gate in Gates)
        {
            // Foreach gate let them know the blue key was taken
            Gate.SendMessage("BlueKeyPickedUp", SendMessageOptions.DontRequireReceiver);
        }

        SoundManager.Instance.blueKeyAudio();
    }
}
