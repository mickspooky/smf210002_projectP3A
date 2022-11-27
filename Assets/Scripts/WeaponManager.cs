using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
  


    
}

public class Singleton : MonoBehaviour { 
    public static Singleton Instance;
    public void SwitchWeapon(SpawnWeapon weaponToSpawn)
    {
        if (Instance != null)
        {
            Instance = this;
            DontDestroyOnLoad(weaponToSpawn);
            Debug.Log("spawn new weapon");


        }
        else
        {
            Destroy(weaponToSpawn);
        }
    }

}
