using UnityEngine;
using UnityEngine.UI;

public class CustomMenu : MonoBehaviour
{
    public GameObject customMenu;

    public GameObject cubySprite1;
    public GameObject cubySprite2;

    public GameObject cubilleSprite1;
    public GameObject cubilleSprite2;

    public GameObject cuboolSprite1;
    public GameObject cuboolSprite2;

    public Color32 color;

    public static CustomMenu instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de CustomMenu dans la scène");
            return;
        }

        instance = this;
    }

    public void ExitCustomMenu()
    {
        customMenu.SetActive(false);
    }

    public void UpdateColor()
    {
        cubySprite1.GetComponent<Image>().color = color;
        cubySprite2.GetComponent<Image>().color = color;

        cubilleSprite1.GetComponent<Image>().color = color;
        cubilleSprite2.GetComponent<Image>().color = color;

        cuboolSprite1.GetComponent<Image>().color = color;
        cuboolSprite2.GetComponent<Image>().color = color;
    }

    public void RedColorSwap()
    {
        color = new Color32(255, 0, 0, 255);
        UpdateColor();
    }

    public void OrangeColorSwap()
    {
        color = new Color32(255, 176, 0, 255);
        UpdateColor();
    }

    public void YellowColorSwap()
    {
        color = new Color32(255, 255, 0, 255);
        UpdateColor();
    }

    public void GreenColorSwap()
    {
        color = new Color32(0, 255, 19, 255);
        UpdateColor();
    }

    public void BlueColorSwap()
    {
        color = new Color32(0, 24, 255, 255);
        UpdateColor();
    }

    public void PurpleColorSwap()
    {
        color = new Color32(142, 0, 255, 255);
        UpdateColor();
    }

    public void WhiteColorSwap()
    {
        color = new Color32(255, 255, 255, 255);
        UpdateColor();
    }
}
