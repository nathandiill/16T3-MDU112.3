using UnityEngine;
using System.Collections;

public class BlueKey : Key
{
    public string BlueKeyPickedUp;
    public GameObject[] Gates;

    void OnTriggerEnter2D(Collider2D other)
    {
        Gates = GameObject.FindGameObjectsWithTag("Gate");
        foreach (GameObject Gate in Gates)
        {
            Gate.SendMessage("BlueKeyPickedUp", SendMessageOptions.DontRequireReceiver);
        }

        SoundManager.Instance.blueKeyAudio();
    }
}
