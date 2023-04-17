using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExample 
{
    private int totalLife;
    private int currentLife;
    private string name;
    private string power;

    public EnemyExample(int totalLife)
    {
        this.totalLife = totalLife;
        currentLife = totalLife;
    }

    public int CurrentLife()
    {
        return(currentLife);
    }

    public void SetEnemyName(string name)
    {
        this.name = name;
    }

    public void SetEnemyPower(string power)
    {
        this.power = power;
    }

    public int Damage(int damage)
    {
        currentLife -= damage;
        return(currentLife);
    }
}
