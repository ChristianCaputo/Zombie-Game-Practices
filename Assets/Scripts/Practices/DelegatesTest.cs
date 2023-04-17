using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatesTest : MonoBehaviour
{
    public delegate void MyDelegate (int num); // Declaración del Delegado.
    MyDelegate myDelegate; // "Variable" del tipo del delegado. El delegado contendrá metodo/s.
    
    void Start()
    {
        myDelegate = PrimNum; // Asigno el metodo al delegado (como un valor a una variable).
        myDelegate(50);  // Invoco al metodo directamente con el delegado, enviandole además el valor al parámetro.

        myDelegate += SecNum;

        myDelegate(50);

    }

    void PrimNum(int num)
    {
        print(num);
    }

    void SecNum(int num)
    {
        print(num * 2);
    }
    
}
