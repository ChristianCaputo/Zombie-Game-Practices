using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacTranslation : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.ButtonEvent += Translation;
    }

    void OnDisable()
    {
        EventManager.ButtonEvent -= Translation;
    }

    void Translation()
    {
        //transform.Translate(10, 0, 0);
        Debug.Log("move!");
    }

}
