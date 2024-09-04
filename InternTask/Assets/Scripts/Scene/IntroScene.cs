using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScene : SceneControl
{
    public DataManager dataManager;

    private void Start()
    {
        StartCoroutine(Init());
    }

    private IEnumerator Init()
    {
        yield return dataManager.LoadData();
    }
}
