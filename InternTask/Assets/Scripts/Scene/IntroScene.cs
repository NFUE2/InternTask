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
        ui.infoText.text = "�����͸� �ҷ��������Դϴ�.";

        yield return dataManager.LoadData();

        ui.infoText.text = "ȭ���� Ŭ�����ּ���";
        ui.button.interactable = true;
    }
}
