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
        Init();
    }

    private async void Init()
    {
        monsters = new List<GameObject>();

        await Addressables.LoadAssetsAsync<GameObject>("Monster",g => {
            GameObject m = Instantiate(g,start.position,Quaternion.identity);
            monsters.Add(m);
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
