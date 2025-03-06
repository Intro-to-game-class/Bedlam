using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IN THIS SCRIPT: Use this script to a random item in random quantities to the Inventory
// WARNING: This script uses UNITY Editor to simplify the process of setting it up
// USE THIS SCRIPT by attaching it next to the script that calls the AddItem() and set up what you want to Add to the inventory in the Editor
public class AddRandomItemToInventory : MonoBehaviour
{
  
    // In case of random, this list becomes active in the Editor
    public List<Item> itemsToGive = new List<Item>();

    // The minimum number of a random item to be given, needs to be at least 1
    public int minimumItemsToGive = 1;

    // The maximum number of a random item to be given, needs to be at least 1
    public int maximumItemsToGive = 1;


    // Adds one random Item from the pre selected list to the Inventory
    //The quantity to be added is also random based on the minimumItemsToGive and maximumItemsToGiv
    public void AddRandomItem()
    {
        Inventory.instance.AddItem(itemsToGive[Random.Range(0, itemsToGive.Count)], Random.Range(minimumItemsToGive, maximumItemsToGive));
    }

}
