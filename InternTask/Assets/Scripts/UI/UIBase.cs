using UnityEngine;
using UnityEngine.UI;

public class UIBase : MonoBehaviour
{
    public Canvas canvas;
    public virtual void Show(string name)
    {
        GameObject newCanvas = new GameObject($"{name}Canvas");
        transform.SetParent(newCanvas.transform);

        canvas = newCanvas.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        CanvasScaler scaler = newCanvas.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(Screen.width,Screen.height);
        newCanvas.AddComponent<GraphicRaycaster>();
        
    }

    public virtual void Open(object[] param) => gameObject.SetActive(true);
    public virtual void Close(object[] param) => gameObject.SetActive(false);
}
