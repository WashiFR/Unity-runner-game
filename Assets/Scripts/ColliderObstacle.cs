using UnityEngine;

public class ColliderObstacle : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.ScoreUp();
        }
    }
}