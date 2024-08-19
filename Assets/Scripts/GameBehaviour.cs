using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomExtentions;

public class GameBehaviour : MonoBehaviour, IManager
{
    public string labelText = "Collect four items and win a prize";
    

    public bool showWinScreen = false;
    public bool showLossScreen = false;

    public int maxItems = 4;
    private int _itemsCollected = 0;
    public Stack<string> lootStack = new Stack<string>();

    private string _state;

    
    
    

    void Start()
    {
        Initialize();
        InventoryList<string> inventoryList = new InventoryList<string>();
        inventoryList.SetItem("Potion");
        Debug.Log(inventoryList.GetItem);
    }

    public string State
    {
        get { return _state; }
        set { value = _state; }
    }

    void AllCollected()
    {
        labelText = "You have collected all needed";
        showWinScreen = true;
        Time.timeScale = 0f;
    }

    public int Items
    {
        get { return _itemsCollected; }
        set {
            _itemsCollected = value;
            Debug.LogFormat("You have {0} items in your backpack", _itemsCollected);
            if (_itemsCollected >= maxItems)
            {
                AllCollected();
            }
            else
            {
                labelText = "Item found, but " + (maxItems - _itemsCollected) + " more to go!";
            }
        }

    }

    public void Initialize()
    {
        _state = "Manager initialized ....";
        //_state.FancyDebug();
        Debug.Log(_state);
        lootStack.Push("Sword of DOOM");
        lootStack.Push("Golden key");
        lootStack.Push("HP+");
        lootStack.Push("Winged boot");
        lootStack.Push("Mythril bracers");
    }

    
    void Death()
    {
        labelText = "You need another life";
        showLossScreen = true;
        Time.timeScale = 0;
    }

    private int _playerHealth = 5;

    public int Health
    {
        get { return _playerHealth; }
        set
        {
            _playerHealth = value;
            if (_playerHealth <= 0)
            {
                Death();
            }
            else
            {
                labelText = "Ouch ! That's hurt";
            }
            Debug.LogFormat($"{_playerHealth} HP");
        }
    }


    /*void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale= 1.0f;
    }*/

    private void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player's health:" + _playerHealth);
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + _itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);
        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                Utilities.RestartLevel(0);
            }
        }
        if (showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You lose...")) {
                Utilities.RestartLevel();
            }
        }
    }

    public void LootReport()
    {
        var currentItem = lootStack.Pop();
        var nextItem = lootStack.Peek();
        Debug.LogFormat(" You got a {0}, next will be {1} i suppose ?", currentItem, nextItem);
        Debug.LogFormat("There are {0} items in your loot bag", lootStack.Count);
    }
}
