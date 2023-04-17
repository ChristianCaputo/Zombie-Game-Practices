using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourEventsPractise : MonoBehaviour
{
    //private MonoBehaviourEventsPractise mbep;

    /*void Awake()
    {
        mbep = GetComponent<MonoBehaviourEventsPractise>();
    }
    */
    void Start()
    {
        /*Invoke("SetObjectInactive", 3f);
        Invoke("SetObjectActive", 10f);
        Invoke("DisableComponent", 15f);*/
        print("voidStart");
    }
/*
    void SetObjectActive()
    {
        gameObject.SetActive(true);
    }

    void SetObjectInactive()
    {
        gameObject.SetActive(false);
    }*/

    void OnEnable()
    {
        print ("OnEnable");
    }

    void OnDisable()
    {
        print("OnDisable");
    }

    /*void DisableComponent()
    {
        mbep.enabled = false;
        Invoke("EnableComponent", 3f);
    }

    void EnableComponent()
    {
        mbep.enabled = true;
    }
  */
}
