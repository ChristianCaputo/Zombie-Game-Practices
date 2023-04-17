using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : Life
{
    [SerializeField] private GameManager gameMgr;
    
    public override void SetInitialLife()
    {
        initialLife = 100;
    }
    
    public override void Dead()
    {
        gameMgr.Dead();
    }

}










 
 
 
 
 
 
 
 /*public override void Start()
    {
        initialLife = 100;
        currentLife = initialLife;
        //print("Vida personaje" + currentLife);
    }*/