using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour  //Encargado de deteccion de inputs de disparo y animacion
{   
    private int initialAmmunition = 100;
    private int currentAmmunition;
    private GameObject shooter;

    [SerializeField] private CharacterMovement characMovScript;
    public CameraBehaviour cameraAiming;

    //Sonido
    public void Start()
    {
        currentAmmunition = initialAmmunition;
        shooter = GameObject.Find("Shooter");
        cameraAiming.enabled = false; 

    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {       
            Shoot();
        }
        else
        {
            shooter.SetActive(false);
            characMovScript.animator.SetBool("Shoot", false);
            characMovScript.velocity = 10;
            cameraAiming.enabled = false; 
        }
    }

    public void Shoot()
    {
        shooter.SetActive(true);
        characMovScript.velocity = 0;
        characMovScript.animator.SetBool("Shoot", true);
        currentAmmunition -= 1;
        cameraAiming.enabled = true;
        //print(currentAmmunition);
    }
}