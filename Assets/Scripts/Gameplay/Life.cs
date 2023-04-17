using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Life : MonoBehaviour
{
    [SerializeField] protected int initialLife;
    [SerializeField] protected int currentLife;

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
    
    public int GetLife()
    {
        return(currentLife);
    }

    public abstract void SetInitialLife();

    public abstract void Dead();
    // Comunicación con el Game Mgr

}

