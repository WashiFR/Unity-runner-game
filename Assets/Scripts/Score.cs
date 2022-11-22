using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public int bestScore;
    public Text bestScoreText;

    public AudioSource audioSource;
    public AudioClip soundEffect;

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

        if(score > bestScore)
        {
            bestScore = score;
        }

        if (score % 2 == 0)
        {
            GameSpeed.instance.GameSpeedIncrease();
        }
        if (score % 10 == 0)
        {
            audioSource.PlayOneShot(soundEffect);
        }

        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
        bestScoreText.text = bestScore.ToString();
    }
}
