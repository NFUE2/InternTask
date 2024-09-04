using JetBrains.Annotations;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class MapManager : Singleton<MapManager>
{
    private List<GameObject> monsters;
    private int curCount;
    [field: SerializeField] public Transform destination { get; private set; }
    [field: SerializeField] public Transform start { get; private set; }

    public override void Awake()
    {
        base.Awake();
        Init();
    }

    private async void Init()
    {
        monsters = new List<GameObject>(DataManager.dict.Count);

        await Addressables.LoadAssetsAsync<GameObject>("Monster",g => {

            GameObject m = Instantiate(g,start.position,Quaternion.identity);

            int id = (int) m.GetComponent<MonsterControl>().data.grade;

            monsters[id] = m;
            m.SetActive(false);

        }).Task;
    }
   
    public void SpawnMonster()
    {
        curCount = (curCount + 1) % monsters.Count;
        monsters[curCount].SetActive(true);
        monsters[curCount].transform.position = start.position;
    }
}
