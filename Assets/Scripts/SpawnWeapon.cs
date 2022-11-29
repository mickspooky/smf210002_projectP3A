using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class SpawnWeapon : MonoBehaviour
{
    //public GameObject weaponToSpawn;
    public int totalWeapons = 1;
    public int currentWeaponID = 0;
    public static GameObject Instance = null;
    public GameObject weaponHolder;
    public GameObject[] Weapons;
    public GameObject currentWeapon;
    public static SpawnWeapon instance;
    public TextMeshProUGUI itemText;
    public string itemName;



    // Start is called before the first frame update
    void Start()
    {
       
        

        totalWeapons = weaponHolder.transform.childCount;
        Weapons = new GameObject[totalWeapons];

        for (int i = 0; i < totalWeapons; i++)
        {
            Weapons[i] = weaponHolder.transform.GetChild(i).gameObject;
            Weapons[i].SetActive(false);
           
        }

        Weapons[0].SetActive(true);
        currentWeapon = Weapons[0];
        currentWeaponID = 0;

    }

    public void Weapon1()
    {

        Weapons[currentWeaponID].SetActive(false);
        currentWeaponID = 5;
        Weapons[currentWeaponID].SetActive(true);
       
    }
    public void Weapon2()
    {
        Weapons[currentWeaponID].SetActive(false);
        currentWeaponID = 2;
        Weapons[currentWeaponID].SetActive(true);
    }
    public void Weapon3()
    {
        Weapons[currentWeaponID].SetActive(false);
        currentWeaponID = 4;
        Weapons[currentWeaponID].SetActive(true);
    }
    public void Weapon4()
    {
        Weapons[currentWeaponID].SetActive(false);
        currentWeaponID = 0;
        Weapons[currentWeaponID].SetActive(true);
    }
    public void Weapon5()
    {
        Weapons[currentWeaponID].SetActive(false);
        currentWeaponID = 3;
        Weapons[currentWeaponID].SetActive(true);
    }
    public void Weapon6()
    {
        Weapons[currentWeaponID].SetActive(false);
        currentWeaponID = 1;
        Weapons[currentWeaponID].SetActive(true);
    }
    



    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.E))
        // {
        //if(currentWeaponID < totalWeapons - 1)
        //{
        // Weapons[currentWeaponID].SetActive(false);
        // currentWeaponID += 1;
        // Weapons[currentWeaponID].SetActive(true);
        //}
        //}

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        // if (currentWeaponID > 0)
        // {
        // Weapons[currentWeaponID].SetActive(false);
        // currentWeaponID -= 1;
        // Weapons[currentWeaponID].SetActive(true);
        //}
        //}

        
    }




}

