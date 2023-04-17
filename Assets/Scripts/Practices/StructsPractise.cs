using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructsPractise : MonoBehaviour
{
    public struct EnemyData
    {
        public string name;
        public int health;
    }

    public EnemyData enemyData;

    void Start()
    {
        enemyData.name = "zombie";
        enemyData.health = 100;
        //Debug.Log (enemyData.name);
    }


}
