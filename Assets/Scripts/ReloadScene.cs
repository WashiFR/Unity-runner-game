using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    private void Update()
    {
        if(GameOverMenu.instance.isGameOver)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                GameOverMenu.instance.RestartGame();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
