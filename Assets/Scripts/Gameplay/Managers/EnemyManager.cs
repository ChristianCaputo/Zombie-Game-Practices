using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private int enemyesInScene;
    private int enemyesDead;

    public void Start()
    {
        Debug.Log ("Enemigos en escena:" + enemyesInScene);
    }
    
    public void SetEnemyesInScene(int enemyesInScene)
    {
        this.enemyesInScene += enemyesInScene;
    }

    public int GetEnemyes()
    {
        return enemyesInScene;
    }
    
    public void DeadCounter(int deadEnemy)
    {
        enemyesDead += deadEnemy;
        enemyesInScene -= deadEnemy;
    }
}
