using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    public float gameSpeed;

    public static GameSpeed instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de GameSpeed dans la scène");
            return;
        }

        instance = this;
    }

    public void GameSpeedIncrease()
    {
        gameSpeed += 0.1f;
    }
}
