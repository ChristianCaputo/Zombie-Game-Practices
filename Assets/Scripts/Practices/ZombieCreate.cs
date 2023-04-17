using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCreate : MonoBehaviour
{
    [SerializeField] private GameObject zombie;
    
    void OnEnable()
    {
        EventManager.ButtonEvent += NewZombie; // Suscribo metodo al evento.
    }   // Accedo directamente al evento sin instanciar la clase.

    void OnDisable()
    {
        EventManager.ButtonEvent -= NewZombie;
    }

    void NewZombie() // Metodo que se suscribe al evento.
    {
        Instantiate(zombie, transform.position, transform.rotation);
    }

}
