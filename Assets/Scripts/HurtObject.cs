using UnityEngine;

public class HurtObject : MonoBehaviour
{
    private void Update()
    {
        transform.position -= new Vector3(GameSpeed.instance.gameSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameOverMenu.instance.LoadGameOverMenu();
            LoadAndSaveData.instance.SaveData();
        }
    }
}
