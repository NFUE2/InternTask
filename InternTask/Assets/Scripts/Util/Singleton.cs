using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;

                if(instance == null)
                {
                    GameObject g = new GameObject(typeof(T).Name);
                    instance = g.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    public virtual void Awake()
    {
        if (instance != null) Destroy(gameObject);
        else DontDestroyOnLoad(gameObject);
    }
}
