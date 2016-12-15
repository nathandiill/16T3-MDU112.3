using UnityEngine;
using System.Collections;

public class YellowKey : Key
{
    public string YellowKeyPickedUp;
    public GameObject[] Gates;

    // Find objects with gate tag
    void OnTriggerEnter2D(Collider2D other)
    {
        Gates = GameObject.FindGameObjectsWithTag("Gate");
        foreach (GameObject Gate in Gates)
        {
            // Foreach gate let them know the yellow key was taken
            Gate.SendMessage("YellowKeyPickedUp", SendMessageOptions.DontRequireReceiver);
        }

        SoundManager.Instance.yellowKeyAudio();
    }
}
