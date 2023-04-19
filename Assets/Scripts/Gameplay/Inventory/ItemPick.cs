using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPick : MonoBehaviour
{
    public Item itemData;

    public void OnTriggerEnter(Collider c)
    {
        Inventory inventory = c.GetComponentInParent<Inventory>();
        inventory.items.Add(itemData);
        Destroy(gameObject);
    }
}
