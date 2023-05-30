using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPick : MonoBehaviour
{
    public Item itemData;

    public void OnTriggerEnter(Collider c)
    {
        Inventory inventory = c.GetComponentInParent<Inventory>();
        print($"Picked: {itemData}");
        inventory.items.Add(itemData);
        Destroy(gameObject);
        print("Inventory: ");
        for(int i = 0; i < inventory.items.Count; i++)
        {
            print($"{inventory.items[i].itemName}, ");
        }
    }
}
