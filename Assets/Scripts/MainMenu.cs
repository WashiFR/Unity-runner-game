using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGameButton()
    {
        SceneManager.LoadScene("Level01");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
