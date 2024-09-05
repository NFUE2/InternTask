using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class MonsterInfoUI : UIBase
{
    public Text nameText;
    public Text gradeText;
    public Text speedText;
    public Text healthText;

    MonsterData data;

    public override void Open(object[] param)
    {
        base.Open(param);
        data = (MonsterData)param[0];

        nameText.text = data.name;
        gradeText.text = gradeText.text.Replace("value",data.grade.ToString());
        speedText.text = speedText.text.Replace("value", data.speed.ToString());
        healthText.text = healthText.text.Replace("value", data.health.ToString());
    }

    public override void Close(object[] param)
    {
        gradeText.text = gradeText.text.Replace(data.grade.ToString(), "value");
        speedText.text = speedText.text.Replace(data.speed.ToString(), "value");
        healthText.text = healthText.text.Replace(data.health.ToString(), "value");

        base.Close(param);
    }

    public void Close()
    {
        Close(null);
    }
}
