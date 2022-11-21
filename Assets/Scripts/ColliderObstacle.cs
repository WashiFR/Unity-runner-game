using UnityEngine;
using System.Collections;

public class ColliderObstacle : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.instance.ScoreUp();
            StartCoroutine(DeleteObject2SecondsAfter());
        }
        if(collision.gameObject.CompareTag("SpawnObjects"))
        {
            Instantiate(transform.parent.gameObject, new Vector3(Random.Range(20, 30), 0.345f, 0), Quaternion.identity);
        }
    }

    IEnumerator DeleteObject2SecondsAfter()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(transform.parent.gameObject);
    }
}