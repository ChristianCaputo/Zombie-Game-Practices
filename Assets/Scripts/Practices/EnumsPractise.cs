using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumsPractise : MonoBehaviour
{
    public enum ZombieAttack { None, Vomit, Bite, Punch }
    public ZombieAttack zombieAttack;

    private void Start()
    {
        zombieAttack = ZombieAttack.Vomit;
    }



}
