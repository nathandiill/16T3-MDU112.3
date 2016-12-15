using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;

    void Awake()
    {
        Instance = this;
    }

    private Rigidbody2D rb;
    private Vector2 userInput;
    public float movementSpeed = 5.0f;

    private SpriteRenderer sr;
    private Color originalColor;

	void Start ()
    {
        // Retrieve the Ridgidbody from gameObject
        rb = gameObject.GetComponent<Rigidbody2D>();

        sr = gameObject.GetComponent<SpriteRenderer>();
        originalColor = sr.color;
    }

    // Retrieve user input
    void Update ()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        userInput = new Vector2(horizontal, vertical);
    }

    void FixedUpdate()
    {
        // Call movement in FixedUpdate
        Vector2 newPosition = transform.position;
        newPosition += userInput * movementSpeed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Attempt to retrieve the other objects spiter renderer
        SpriteRenderer otherSR = other.gameObject.GetComponent<SpriteRenderer>();

        // Was the Sprite Renderer retrieved?
        if (otherSR != null)
        {
            sr.color = otherSR.color;
        }

        Debug.Log(other.gameObject.tag);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
    }
}
