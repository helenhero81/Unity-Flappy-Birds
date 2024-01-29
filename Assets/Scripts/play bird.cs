using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    public float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private int score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for jump input
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        // Check if the bird is on the ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }

    void FixedUpdate()
    {
        // Move the bird forward
        rb.velocity = new Vector2(2f, rb.velocity.y);

        // Check if the bird is falling too fast, limit the fall speed
        if (rb.velocity.y < -2f)
        {
            rb.velocity = new Vector2(rb.velocity.x, -2f);
        }
    }

    void Jump()
    {
        // Jump only if the bird is on the ground
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check for collision with pipes
        if (other.CompareTag("Pipe"))
        {
            GameOver();
        }
        // Check for passing through pipes
        else if (other.CompareTag("PipeScore"))
        {
            IncreaseScore();
        }
    }

    void GameOver()
    {
        // Handle game over logic (e.g., display game over screen, reset score)
        Debug.Log("Game Over!");
    }

    void IncreaseScore()
    {
        // Increment the score when passing through pipes
        score++;
        Debug.Log("Score: " + score);
    }
}
