using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void TimeOut()
    {
        Debug.Log("TIME OUT!");
        Invoke("ChangeScene", 2);
    }

    public void Dead()
    {
        Debug.Log("DEAD!");
        Invoke("ChangeScene", 2);
    }

    public void Win()
    {
        Debug.Log("YOU WIN!");
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Scene1");
    }
}
