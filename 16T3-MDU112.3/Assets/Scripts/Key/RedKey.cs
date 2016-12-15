using UnityEngine;
using System.Collections;

public class RedKey : Key
{
    public string RedKeyPickedUp;
    public GameObject[] Gates;

    void OnTriggerEnter2D(Collider2D other)
    {
        Gates = GameObject.FindGameObjectsWithTag("Gate");
        foreach (GameObject Gate in Gates)
        {
            Gate.SendMessage("RedKeyPickedUp", SendMessageOptions.DontRequireReceiver);
        }

        SoundManager.Instance.redKeyAudio();
    }
}
