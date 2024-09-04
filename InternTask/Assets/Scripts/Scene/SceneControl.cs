using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadSene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
