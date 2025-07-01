using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake()
    {
        Instance = this; // assign instance to the static variable
        DontDestroyOnLoad(gameObject);
    }
}
