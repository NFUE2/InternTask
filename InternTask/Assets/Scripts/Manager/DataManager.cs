using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class MonsterData
{
    public string name;
    public Grade grade;
    public float speed;
    public float health;
}

public class DataManager : MonoBehaviour
{
    public static readonly Dictionary<string,MonsterData> dict = new Dictionary<string,MonsterData>();

    private string path = $"https://docs.google.com/spreadsheets/d/1kjsH90QXjnVyyNlh3ayKW4pU4f8H8SF1TtF9zuNGLnI/export?format=csv&gid=0";

    public IEnumerator LoadData()
    {
        UnityWebRequest www = UnityWebRequest.Get(path);

        yield return www.SendWebRequest();

        string data = www.downloadHandler.text;

        CSVToJson(data);
    }

    private void CSVToJson(string str)
    {
        List<string> keys = new List<string>();
        string[] datas = str.Trim().Split('\n');

        for (int i = 0; i < datas.Length; i++)
        {
            string[] arr = datas[i].Split(',');

            for (int j = 0; j < arr.Length; j++)
            {
                if (i == 0) keys.Add(arr[j].ToLower());
                else
                {
                    var m = JsonUtility.FromJson<MonsterData>(CreateJson(keys, arr));
                    dict[m.name] = m;
                }
            }
        }
    }

    private string CreateJson(List<string> keys,string[] data)
    {
        StringBuilder json = new StringBuilder();

        json.Append("{");
        for (int i = 0; i < data.Length; i++)
        {
            if (i != 0) json.Append(",");

            json.Append($"\"{keys[i]}\":");

            if (i == 0) json.Append($"\"{data[i]}\"");
            else if (i == 1)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (((Grade)j).ToString().Equals(data[i]))
                    {
                        json.Append($"{j}");
                        break;
                    }
                }
            }
            else json.Append($"{data[i]}");
        }
        json.Append("}");
        json = json.Replace("\r", "");

        return json.ToString();
    }
}
