using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour
{
    private SpriteRenderer sr;
    private Color thisColor;

    // Use this for initialization
    void Start ()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        thisColor = sr.color;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        // Attempt to retrieve the other objects spiter renderer
        SpriteRenderer otherSR = other.gameObject.GetComponent<SpriteRenderer>();

        // Was the Sprite Renderer retrieved?
        if (otherSR != null)
        {
            
        }
    }
}
