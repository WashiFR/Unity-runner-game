using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public GameObject[] players;
    public int playerSelected;

    void Start()
    {
        playerSelected = CharacterSelection.instance.selectedCharacter;
        for (int i = 0; i < players.Length; i++)
        {
            players[i].SetActive(false);
        }
        players[playerSelected].SetActive(true);
    }
}
