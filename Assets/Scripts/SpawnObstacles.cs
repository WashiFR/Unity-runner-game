using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    private int obstacleNumber;
    public GameObject[] obstacles;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            int randomObstacle = Random.Range(0, 10);
            if(randomObstacle <= 5)
            {
                obstacleNumber = 0;
            }
            else if(randomObstacle > 5 && randomObstacle <= 8)
            {
                obstacleNumber = 1;
            }
            else
            {
                obstacleNumber = 2;
            }
            Instantiate(obstacles[obstacleNumber].gameObject, new Vector3(Random.Range(18, 24), 0.29f, 0), Quaternion.identity);
        }
    }
}
