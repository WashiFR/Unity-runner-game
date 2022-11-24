using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenu;
    public bool isGameOver = false;

    public AudioSource audioSource;
    public AudioClip soundEffect;

    public static GameOverMenu instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de GameOverMenu dans la scène");
            return;
        }

        instance = this;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        isGameOver = false;
        gameOverMenu.SetActive(false);
        //Cursor.visible = false;
    }

    public void LoadGameOverMenu()
    {
        audioSource.PlayOneShot(soundEffect);
        Time.timeScale = 0;
        isGameOver = true;
        gameOverMenu.SetActive(true);
        //Cursor.visible = true;
    }

    public void RetryGameButton()
    {
        RestartGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
