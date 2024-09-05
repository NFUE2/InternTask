using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    Dictionary<string, UIBase> dict = new Dictionary<string, UIBase>();
    const string path = "Assets/Prefab/UI/";

    public override void Awake()
    {
        base.Awake();
        Show<IntroSceneUI>();
    }

    public void Show<T>(params object[] param) where T : UIBase
    {
        string uiName = typeof(T).ToString();
        dict.TryGetValue(uiName, out UIBase ui);

        if (ui == null)
        {
            Addressables.InstantiateAsync(uiName).Completed += (handle) =>
            {
                var g = handle.Result;

                ui = g.GetComponent<UIBase>();
                ui.Show(uiName);

                dict.Add(uiName, ui);

                ui.canvas.sortingOrder = dict.Count;
                ui.Open(param);
            };
        }
        else ui.Open(param);
    }
}
