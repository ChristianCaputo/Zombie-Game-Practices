using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void PressButton(); // Creo el delegado.
    public static event PressButton ButtonEvent; // Creo el evento a partir del delegado.

    void Update() // Indico cuándo quiero que suceda el evento.
    {
        if(Input.GetButtonDown("Jump"))
        {
            ButtonEvent(); // Llamo al Evento cuando se presiona el Input "Jump".
        }
    }
}
