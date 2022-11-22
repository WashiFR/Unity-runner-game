using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score;
    public Text scoreText;

    public static Score instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de Score dans la scène");
            return;
        }

        instance = this;
    }

    public void ScoreUp()
    {
        score++;

        if(score % 10 == 0)
        {
            GameSpeed.instance.GameSpeedIncrease();
        }

        scoreText.text = score.ToString();
    }
}
