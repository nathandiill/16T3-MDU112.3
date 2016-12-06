using UnityEngine;
using System.Collections;

public class YellowKey : Key
{
    public string YellowKeyPickedUp;
    public GameObject[] Gates;

    void OnTriggerEnter2D(Collider2D other)
    {
        Gates = GameObject.FindGameObjectsWithTag("Gate");
        foreach (GameObject Gate in Gates)
        {
            Gate.SendMessage("YellowKeyPickedUp", SendMessageOptions.DontRequireReceiver);
        }               
    }
}
