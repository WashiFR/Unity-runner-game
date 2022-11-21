using UnityEngine;
using System.Collections;

public class ColliderAddScore : MonoBehaviour
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
        yield return new WaitForSeconds(0.5f);
        Instantiate(transform.parent.gameObject, new Vector3(Random.Range(15, 20), 0.5f, 0), Quaternion.identity);
        Destroy(transform.parent.gameObject);
    }
}