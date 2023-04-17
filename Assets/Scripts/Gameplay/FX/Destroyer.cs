using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 0.2f);
    }

    // Update is called once per frame
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
