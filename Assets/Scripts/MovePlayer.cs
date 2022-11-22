using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float jumpForce;
    public bool isGrounded;

    public Rigidbody2D rb;

    void Update()
    {
        if(!PauseMenu.instance.gameIsPaused && !GameOverMenu.instance.isGameOver)
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
            else if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow)) && !isGrounded)
            {
                rb.AddForce(Vector2.down * jumpForce);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(!isGrounded)
            {
                isGrounded = true;
            }
        }
    }
}
