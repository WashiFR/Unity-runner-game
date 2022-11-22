using UnityEngine;

public class LoadAndSaveData : MonoBehaviour
{
    public static LoadAndSaveData instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de LoadAndSaveData dans la scène");
            return;
        }

        instance = this;
    }

    void Start()
    {
        Score.instance.bestScore = PlayerPrefs.GetInt("bestScorePlayer", 0);
        Score.instance.UpdateScoreUI();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("bestScorePlayer", Score.instance.bestScore);
    }
}
