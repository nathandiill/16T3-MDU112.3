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

    public GameObject projectilePrefab;
    public GameObject[] Muzzles;
    public float projectileForce = 200f;

    public float fireInterval = 1f;
    private float timeUntilCanFire = 0f;

	void Start ()
    {
        // Retrieve the Ridgidbody from gameObject
        rb = gameObject.GetComponent<Rigidbody2D>();

        sr = gameObject.GetComponent<SpriteRenderer>();
        originalColor = sr.color;
    }

    // Reusable function to fire the weapon
    void Fire (string button, int muzzlenumber)
    {
        if (Input.GetButton(button) && timeUntilCanFire <= 0)
        {
            // Weapon on cooldown
            timeUntilCanFire = fireInterval;

            // Select muzzle
            GameObject Muzzle = Muzzles[muzzlenumber];

            // Retrieve Location
            Vector3 muzzleLocation = Muzzle.transform.position;

            // Direction to fire
            Vector3 fireDirection = muzzleLocation - transform.position;

            // Instantiate the projectile
            GameObject newProjectile = Instantiate(projectilePrefab);

            // Position projectile at muzzle
            newProjectile.transform.position = muzzleLocation;

            // Retrieve Ridgid body for projectile
            Rigidbody2D projectileRB = newProjectile.GetComponent<Rigidbody2D>();

            // Launch
            projectileRB.AddForce(fireDirection.normalized * projectileForce);

            SoundManager.Instance.fireAudio();
        }
    }

    void Update ()
    {
        // Add the cooldown
        if (timeUntilCanFire > 0)
        {
            timeUntilCanFire -= Time.deltaTime;
        }

        // Fire right muzzle
        Fire("Fire1", 0);

        // Fire left muzzle
        Fire("Fire2", 1);

        // Fire top muzzle
        Fire("Fire3", 2);

        // Fire bottom muzzle
        Fire("Fire4", 3);

        // Retrieve user input
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
