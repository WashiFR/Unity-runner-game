using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject spriteImage1;
    public GameObject spriteImage2;
    public Color color;

    public static SettingsMenu instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de SettingsMenu dans la scène");
            return;
        }

        instance = this;
    }

    public void ExitSettingsMenu()
    {
        settingsMenu.SetActive(false);
    }

    public void UpdateColor()
    {
        spriteImage1.GetComponent<Image>().color = color;
        spriteImage2.GetComponent<Image>().color = color;
    }

    public void RedColorSwap()
    {
        color = new Color(255, 0, 0, 255);
        UpdateColor();
    }

    public void OrangeColorSwap()
    {
        color = new Color(255, 176, 0, 255);
        UpdateColor();
    }

    public void YellowColorSwap()
    {
        color = new Color(255, 255, 0, 255);
        UpdateColor();
    }

    public void GreenColorSwap()
    {
        color = new Color(0, 255, 0, 255);
        UpdateColor();
    }

    public void BlueColorSwap()
    {
        color = new Color(0, 0, 255, 255);
        UpdateColor();
    }

    public void PurpleColorSwap()
    {
        color = new Color(200, 0, 255, 255);
        Debug.Log(color);
        UpdateColor();
    }

    public void WhiteColorSwap()
    {
        color = new Color(255, 255, 255, 255);
        UpdateColor();
    }
}
