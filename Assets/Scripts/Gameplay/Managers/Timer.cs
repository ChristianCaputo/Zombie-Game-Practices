using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float totalTime = 10f;
    public Text timerUI;
    [SerializeField] private GameManager gameMgr;

    void Update()
    {
        timerUI.text = "Time:" + totalTime;
        totalTime -= 1*Time.deltaTime;

        if(totalTime <= 0)
        {
            gameMgr.TimeOut();  
        }
    }
}
