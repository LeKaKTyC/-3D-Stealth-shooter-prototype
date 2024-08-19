using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int currentAge = 30;
    public int addedAge = 1;
    public string variable1 = "Boyz";
    public string variable0 = "Girlz";
    public float P = 3.14f;
    public bool isRight = true;
    public string characterClass = "Ranger";
    public int characterLevel = 80;
    public int currentGold = 55;
    public bool hasDungeonKey = false;
    public string weaponType = "LongSword";
    public bool weaponEquiped = true;
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "BodyArmor";
    public string characterAction = "Attack";
    public int diceRoll = 7;
    public int[] topPlayerScores = { 452, 713, 984 };
    private Transform camTransform;
    public GameObject directionalLight;
    private Transform lightTransform;



    





    // Start is called before the first frame update
    void Start()
    {
        camTransform=this.GetComponent<Transform>(); // иницииализируем переменную camTransform типа Transform и получаем доступ ко всем компонентам класса Transform
        Debug.Log(camTransform.localPosition); // Используем переменную localPosition для отображения в консоли 

        // directionalLight = GameObject.Find("Directional Light"); // инициализировали через метод Find указав в аргументах точное название игрового объекта
        lightTransform = directionalLight.GetComponent<Transform>(); // получили доступ к компоненту Transform через ссылку, которая описана выше
        // GameObject.Find("Directional Light").GetComponent<Transform>(); // заменяет предыдущие 2 строчки (оптимальная макс. длинна строки с кодом)
        Debug.Log(lightTransform.localPosition);

        
        





        









        /*Paladin knight = new Paladin("Denavar");

        knight.PrintStatsInfo();*/

        



        /*Character hero = new Character(); // Используем базовый конструктор

        hero.PrintStatsInfo();

        Character heroine = new Character("Sherill"); // Используем перегруженный конструктор

        heroine.PrintStatsInfo();*/





        /*Weapon lightBow = new Weapon("LightBow", 55); // копируем структуру экземпляра Weapon для добавления нового оружия с другими характеристиками

        Weapon warbow = lightBow;

        warbow.name = "Warbow";

        warbow.damage = 150;

        lightBow.PrintWeaponStats();

        warbow.PrintWeaponStats();

        Debug.LogFormat("{0} named {1} choosed the {2} as a primary weapon", knight, knight.characterName, weaponType);*/

        
        
        
        
        
        /* Character hero2 = new Character();

        hero2 = heroine;

        hero2.characterName = "Vasyan";

        hero2.PrintStatsInfo(); */ 

        // hero2.Reset(); // точечная нотация для защищенных элементов с модом доступа private не доступна для вызова через экземпляр класса

        


        /*int playerLives = 3;

        while (playerLives > 0)
        {
            Debug.LogFormat("Im Still alive and my HP is {0} ", playerLives);
            playerLives--;
        }

        Debug.Log("RIP");*/





        /*Dictionary<string, int> itemInventory = new Dictionary<string, int>
        {
            {"Torch", 5 },
            {"Bandage",3 },
            {"Ham", 10 }
        };

        foreach (KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Item {0} - {1}g", kvp.Key, kvp.Value);
            if (currentGold >= kvp.Value)
            {
                Debug.LogFormat("You bought the {0}", kvp.Key);
                currentGold -= kvp.Value;
                Debug.LogFormat("Current gold is {0}", currentGold);
            }
        }

        //Debug.Log(itemInventory.Count);

        int numberOfTorches = itemInventory["Torch"];
        itemInventory["Torch"] = 10; /*






        /*List<string> questPartyMembers = new List<string>()
        { "John", "Josh", "Jill"};

        for (int i = 0; i < questPartyMembers.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);
            if (questPartyMembers[i] == "Josh")
            {
                Debug.Log("You found Josh!");
            }
        }
        */





        /*foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - here !", partyMember);
        }

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        questPartyMembers.Add("Jerome");
        questPartyMembers.Insert(1, "Javeline");

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);

        foreach (string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - here !", partyMember);
        }
        /*




        /*switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("You've got a 15!");
                break;
            case 20:
                Debug.Log("You've got a 20");
                break;
            default:
                Debug.Log("Pick a card, any card !");
                break;
        }*/





        /*switch (characterAction)
        {
            case "Heal":
                Debug.Log("I am using Healing potion!");
                break;
            case "Attack":
                Debug.Log("Hit'em with a Sword, Herc!");
                break;
            default:
                Debug.Log("Do something, will ya!?");
                break;
        }*/






        //OpenTreasureChamber();

        /*if (weaponEquiped && weaponType == "LongSword")
        {
            Debug.Log("For the KING!");
        }
        else
        {
            Debug.Log("You brought a knife to a gunfight");
        }*/









        /*int characterHealth = 100;
        Debug.Log(characterClass + "-" + characterHealth);
        ComputeAge();
        Debug.Log($"A string can have variables like {variable0} right in between of a string !");
        createCharacter();*/






        /*int nextSkillLevel = GenerateCharacter("Aragorn", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Toldren", characterLevel));*/





        /*if (currentGold > 50)
            Debug.Log("You are rich, man.");
        else if (currentGold < 15)
            Debug.Log("You are pessant.");
        else
            Debug.Log("You are avoiding your taxes.");*/






        /*if (!hasDungeonKey)
        {
            Debug.Log("You shall not pass");
        }
        else
        {
            Debug.Log("You are always welcome");
        }

        if (weaponType != "Longsword")
        {
            Debug.Log("You have a bad taste in weapon choosing");
        }
        else
        {
            Debug.Log("Staffs are 1337");
        }*/








        /*if (hasDungeonKey)
            Debug.Log("You possess the sacred key - enter.");
        else
            Debug.Log("You are not wotrhy, pessant!");*/

        //GenerateCharacter("Kosiposha", characterLevel);
        //TestMethod(GenerateCharacter("Some", 10));





    }
    /// <summary>
    /// Computes a modified age integer
    /// Some random BS
    /// </summary>
    void createCharacter()
    {
        string characterName = "Aragorn";
        Debug.Log(characterName + "-" + characterClass);
    }

    
    void OpenTreasureChamber()
    {
            if (pureOfHeart && rareItem == "BodyArmor")
            {
            if (!hasSecretIncantation)
            {
                Debug.Log("Cleanse your soul!");
            }
            else 
                Debug.Log("You found the treasure!");
            }
    }


    public int GenerateCharacter(string characterName, int characterLevel)
    {
      
        //Debug.LogFormat("Name:{0} - Level:{1}",characterName, characterLevel);
        return characterLevel + 5;
        
    }
    void TestMethod(int value)
    {
        Debug.Log(value);
    }
    void ComputeAge()
    {
        
        Debug.Log(currentAge + addedAge);
        Debug.LogFormat("Hello World! Add {0} and {1} as variable placeholders", variable1, variable0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
