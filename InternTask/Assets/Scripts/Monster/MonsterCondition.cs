using System;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class MonsterCondition : MonoBehaviour,IDamagable
{
    public event Action OnRespawn;
    public event Action OnDie;
    public event Action OnHit;

    public MonsterControl control;
    public GameObject hpCanvas;
    public Image hpBar;
    private Behaviour col;
    public float curhp { get; private set; }

    private void Awake()
    {
        col = GetComponent<Collider2D>();

        OnRespawn += SetHP;
        OnRespawn += ConditionSwitch;

        OnDie += ConditionSwitch;
    }

    private void OnEnable()
    {
        OnRespawn?.Invoke();
    }

    private void OnMouseDown()
    {
        
    }

    public void TakeDamage(float damage)
    {
        curhp = Mathf.Max(curhp - damage, 0);
        hpBar.fillAmount = GetHP();

        OnHit?.Invoke();

        if (curhp == 0) OnDie?.Invoke();
    }
    private float GetHP()
    {
        return curhp / control.data.health;
    }

    private void SetHP()
    {
        curhp = control.data.health;
        hpBar.fillAmount = GetHP();
    }
    private void ConditionSwitch()
    {
        bool isDie = curhp == 0;

        col.enabled = isDie ? false : true;
        hpCanvas.SetActive(!isDie);
    }

    public void Disable() => gameObject.SetActive(false);
}
