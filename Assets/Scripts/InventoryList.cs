using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class InventoryList <T> where T : class
{
    private T _item;
    public T GetItem 
    {
        get 
        {
            return _item; 
        } 
    }

    public InventoryList()
    {
        Debug.Log("Generic list inicialized...");
    }

    public void SetItem(T newItem)
    {
        _item = newItem;
        Debug.Log($"{newItem} added");
    }
}
