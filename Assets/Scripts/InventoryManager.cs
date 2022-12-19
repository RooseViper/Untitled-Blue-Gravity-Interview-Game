using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the Items and Inventory of the Player. Note: This script is using the Singleton Design pattern.
/// </summary>
public class InventoryManager : MonoBehaviour
{
    public PlayerController playerController;
    public Text generalDisplayBalanceText;
    public float balance;
    public static InventoryManager Instance => _instance;
    private static InventoryManager _instance;
   
    
    private void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        generalDisplayBalanceText.text = "" + balance;
    }
}
