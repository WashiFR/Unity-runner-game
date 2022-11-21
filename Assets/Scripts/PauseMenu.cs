using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool gameIsPaused = false;

    public static PauseMenu instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de PauseMenu dans la scène");
            return;
        }

        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Time.timeScale = 1;
                gameIsPaused = false;
                pauseMenu.SetActive(false);
            }
            else if(!GameOverMenu.instance.isGameOver)
            {
                Time.timeScale = 0;
                gameIsPaused = true;
                pauseMenu.SetActive(true);
            }
        }
    }
}