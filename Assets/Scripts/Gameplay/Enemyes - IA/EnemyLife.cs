using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : Life
{
    private EnemyManager enemymgr;

    public void Awake()
    {
        GameObject manager = GameObject.Find("EnemyMgr");
        enemymgr = manager.GetComponent<EnemyManager>();
    }

    public override void SetInitialLife()
    {
        initialLife = 200;
        enemymgr.SetEnemyesInScene(1);
    }

    public override void Dead()
    {
        enemymgr.DeadCounter(1);
        Debug.Log("Enemy Dead!");
        Debug.Log("Enemigos restantes" + enemymgr.GetEnemyes());
        Destroy(gameObject);
    }
}
