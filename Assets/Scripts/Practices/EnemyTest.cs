using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public EnemyExample enemy1;

    void Awake()
    {
        enemy1 = new EnemyExample(100); //creo un objeto de tipo EnemyExample y le envio por parametro 100 de vida inicial
    }

    void Start()
    {
        print($"Current Life: {enemy1.CurrentLife()}");
        enemy1.SetEnemyName("Zombie");
        enemy1.SetEnemyPower("Bite");
    }
}
