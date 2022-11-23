using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void PlayGameButton()
    {
        Time.timeScale = 1;
        gameIsPaused = false;
        pauseMenu.SetActive(false);
    }

    public void MainMenuButton()
    {
        GameOverMenu.instance.RestartGame();
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}