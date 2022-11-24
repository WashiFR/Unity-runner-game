using UnityEngine;

public class SpriteCharacterSelected : MonoBehaviour
{
    public GameObject[] sprites;
    public int spriteSelected;

    public void UpdateSpriteSelected()
    {
        spriteSelected = CharacterSelection.instance.selectedCharacter;
        for(int i = 0; i < sprites.Length; i++)
        {
            sprites[i].SetActive(false);
        }
        sprites[spriteSelected].SetActive(true);
    }
}
