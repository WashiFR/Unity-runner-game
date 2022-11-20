using UnityEngine;

public class HurtObject : MonoBehaviour
{
    public float speed;

    public GameObject gameOverMenu;
    public GameObject spawnObstacle;

    private void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameOverMenu.instance.LoadGameOverMenu();
        }
    }

    public void Spawn()
    {
        spawnObstacle = Instantiate(spawnObstacle);
    }
}
