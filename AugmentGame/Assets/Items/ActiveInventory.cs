using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ActiveInventory : ScriptableObject
{

    public List<ItemScripObj> activeInventory;
    public ItemScripObj emptyItem;

    public void setInventory()
    {
        for(int i = 0; i < 8; i++)
        {
            if(activeInventory[i] == null)
            {
                activeInventory[i] = emptyItem;
            }
        }
    }
}
