using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Item", menuName = "Items")]
public class Item : ScriptableObject
{
    public float attack;
    public float defense;
    public BodyPart bodyPart;
    public GameObject pickPrefab;
    public GameObject equipPrefab;
}
