using UnityEngine;

public class ChangeColorPlayer : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            ButtonChangeColorGreen();
        }
    }

    public void ButtonChangeColorGreen()
    {
        player.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
