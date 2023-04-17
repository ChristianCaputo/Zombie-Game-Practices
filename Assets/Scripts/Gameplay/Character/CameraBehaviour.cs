using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject aimCamera;

    void OnEnable()
    {
        mainCamera.SetActive(false);
        aimCamera.SetActive(true);
    }

    void OnDisable()
    {
        mainCamera.SetActive(true);
        aimCamera.SetActive(false);
    }
}
