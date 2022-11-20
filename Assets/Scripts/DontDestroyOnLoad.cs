using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public GameObject[] objects;

    public static DontDestroyOnLoad instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de DontDestroyOnLoad dans la scène");
            return;
        }

        instance = this;

        foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        }
    }
}
