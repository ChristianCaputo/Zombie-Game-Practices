using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BodyPart { head, body}

public class Inventory : MonoBehaviour
{
    public Item head;
    public Item body;

    public List<Item> items;

}

