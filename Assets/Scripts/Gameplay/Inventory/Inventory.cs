using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum BodyPart { head, body }

public class Inventory : MonoBehaviour
{
    /*public Item head;
    public Item body;*/

    public List<Item> items;

    public void Drop(int itemIndex)
    {
        if(itemIndex < items.Count)
        {
            Item itemToDrop = items [itemIndex];
            items.RemoveAt(itemIndex);
            Instantiate(itemToDrop.pickPrefab, transform.position + transform.forward * 2 + transform.up * 0.2f, transform.rotation);
        }
    }

    public void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Drop(0);
            print("Inventory:");
            for(int i = 0; i < items.Count; i++)
            {
                print($"{items[i].itemName}, ");
            }
        }
    }
}



