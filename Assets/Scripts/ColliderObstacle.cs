using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class ColliderObstacle : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.ScoreUp();
            StartCoroutine(DeleteObject2SecondsAfter());
        }
    }

    IEnumerator DeleteObject2SecondsAfter()
    {
        yield return new WaitForSeconds(1);
        Destroy(transform.parent.gameObject);
    }
}