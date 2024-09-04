using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadSene(Scenes scene)
    {
        SceneManager.LoadScene((int)scene);
    }
}
