using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float jumpForce;
    public bool isGrounded;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;

    public Rigidbody2D rb;

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded && !PauseMenu.instance.gameIsPaused && !GameOverMenu.instance.isGameOver)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
}
