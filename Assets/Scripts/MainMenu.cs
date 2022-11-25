using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject customMenu;
    public GameObject settingsMenu;

    public void StartGameButton()
    {
        SceneManager.LoadScene("Level01");
        Cursor.visible = false;
    }

    public void LoadSettingsMenu()
    {
        settingsMenu.SetActive(true);
    }

    public void LoadCustomMenu()
    {
        customMenu.SetActive(true);
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
