using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public static Score instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de Score dans la sc�ne");
            return;
        }

        instance = this;
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
