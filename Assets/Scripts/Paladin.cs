using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Character
{
    public Paladin (string characterName): base(characterName)
    {

    }

    public Weapon weapon;

    public Paladin(string characterName, Weapon weapon): base(characterName)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Wassup {0} - take your {1}", characterName, weapon);
    }
}
