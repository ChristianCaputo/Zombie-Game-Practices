using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTest : MonoBehaviour
{
    [SerializeField] private int initialLife;
    [SerializeField] private int currentLife;
    private EnemyManager enemymgr;

    public void Awake()
    {
        GameObject manager = GameObject.Find("EnemyMgr");
        enemymgr = manager.GetComponent<EnemyManager>();
    }
    
    public void Start()
    {
        SetInitialLife();
        currentLife = initialLife;
        Debug.Log("Vida inicial" + currentLife);
    }

    public void Damage(int dmg)
    {
       currentLife -= dmg;
       if(currentLife <= 0)
        {
            Dead();
        }
    }
    
    public void SetInitialLife()
    {
        initialLife = 200;
        enemymgr.SetEnemyesInScene(1);
    }
    
    public int GetLife()
    {
        return(currentLife);
    }

    public void Dead()
    {
        enemymgr.DeadCounter(1);
        Debug.Log("Enemy Dead!");
        Debug.Log("Enemigos restantes" + enemymgr.GetEnemyes());
        Destroy(gameObject);
    }


}


