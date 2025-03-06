using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// IN THIS SCRIPT: Use this to save the items and quantities in your Inventory for your next session
// USE THIS SCRIPT by attaching to any object

[System.Serializable]
public class InventoryDataStr
{
    public List<Item> itemList;
    public List<int> intList;
}


public class SaveInventorySystem : MonoBehaviour
{

    //Use this function to save the current inventory
    public void SaveInventory()
    {

        InventoryDataStr saveData = new InventoryDataStr();
        saveData.itemList = Inventory.instance.itemList;
        saveData.intList = Inventory.instance.quantityList;

        string json = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString("InventoryData", json);
        PlayerPrefs.Save();
    }

    //Use this function to Load the current Inventory
    public void LoadInventory()
    {
        
        if (PlayerPrefs.HasKey("InventoryData"))
        {
            string json = PlayerPrefs.GetString("InventoryData");
            InventoryDataStr saveData = JsonUtility.FromJson<InventoryDataStr>(json);

            Inventory.instance.itemList = saveData.itemList;
            Inventory.instance.quantityList = saveData.intList;
            Inventory.instance.UpdateInventoryUI();
        }
        else
        {
            
        }
    }

  

}
