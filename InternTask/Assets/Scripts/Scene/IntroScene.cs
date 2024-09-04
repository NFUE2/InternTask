using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScene : SceneControl
{
    public DataManager dataManager;
    public IntroSceneUI ui;
    private void Start()
    {
        StartCoroutine(Init());
    }

    public IEnumerator Init()
    {
        ui.infoText.text = "데이터를 불러오는중입니다.";

        yield return dataManager.LoadData();

        ui.infoText.text = "화면을 클릭해주세요";
        ui.button.interactable = true;
    }
}
