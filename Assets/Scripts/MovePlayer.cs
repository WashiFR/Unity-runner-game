using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float jumpForce;
    public bool isGrounded;

    public Rigidbody2D rb;

    private void Start()
    {
        if(CharacterSelection.instance.selectedCharacter == 0 || CharacterSelection.instance.selectedCharacter == 1 || CharacterSelection.instance.selectedCharacter == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = SettingsMenu.instance.color;
        }
    }

    void Update()
    {
        if(!PauseMenu.instance.gameIsPaused && !GameOverMenu.instance.isGameOver)
        {
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetMouseButtonDown(0)) && isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
            else if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && !isGrounded)
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
