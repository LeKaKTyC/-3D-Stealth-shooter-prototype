using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Character
{
    public int characterExp = 0; // классовые переменные Персонажа
    public string characterName;

    /*public Character()  // базовый конструктор класса Персонаж
    {
        characterName = "Not assigned";  
    }*/

    public Character(string characterName)
    {
        this.characterName = characterName; // перегрузка конструктора с ключевым словом this
    }

    public virtual void PrintStatsInfo() // метод для вывода в консоль по принципу DRY
    {
        Debug.LogFormat("{0} has {1} exp !", characterName, characterExp);
    }

    private void Reset()
    {
        characterName = "Not assigned";
        characterExp = 0;
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon (string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon - {0} has {1} DMG points !", name, damage);
    }

    
}