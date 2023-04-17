using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavmeshPractice : MonoBehaviour
{
    public NavMeshAgent nma;

    void Start()
    {
        Vector3 destination = new Vector3 (0, 0, 5);
        nma.SetDestination(destination);
    }

}
