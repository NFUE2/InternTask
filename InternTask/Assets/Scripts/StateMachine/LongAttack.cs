using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongAttack : MonoBehaviour
{
    public Transform firePos;
    public GameObject projectile;

    public void Attack()
    {
        Instantiate(projectile,firePos.position,Quaternion.identity);
    }
}
