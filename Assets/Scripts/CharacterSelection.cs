using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public static CharacterSelection instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de CharacterSelection dans la scène");
            return;
        }

        instance = this;
    }

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter++;
        if(selectedCharacter > characters.Length-1)
        {
            selectedCharacter = 0;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter = characters.Length - 1;
        }
        characters[selectedCharacter].SetActive(true);
    }
}
