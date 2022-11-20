using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenu;
    public bool isGameOver = false;

    public static GameOverMenu instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de GameOverMenu dans la sc�ne");
            return;
        }

        instance = this;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGameOver)
        {
            Time.timeScale = 1;
            isGameOver = false;
            gameOverMenu.SetActive(false);
        }
    }

    public void LoadGameOverMenu()
    {
        Time.timeScale = 0;
        isGameOver = true;
        gameOverMenu.SetActive(true);
    }
}
