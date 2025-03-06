using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// IN THIS SCRIPT: Use this script to Add a specific item in a specific quantity to the Player Inventory
// WARNING: This script uses UNITY Editor to simplify the process of setting it up
// USE THIS SCRIPT by attaching it next to the script that calls the AddItem() and set up what you want to Add to the inventory in the Editor

public class AddItemToInventory : MonoBehaviour
{

    // The Specific item you want to add
    public Item specificItem;

    // The Specific quantity you want to add
    public int specificQuant;

    // Adds the specific item and quantity you set up in the Editor to the Inventory
   public void AddSpecificItem()
    {
        Inventory.instance.AddItem(specificItem, specificQuant);
    }

 
}
