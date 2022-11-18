using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnWeapon : MonoBehaviour
{
    public GameObject weaponToSpawn;
    public Button myButton;
    // Start is called before the first frame update
    void Start()
    {
       Button btn = myButton.GetComponent<Button>();
       btn.onClick.AddListener(spawnWeapon);
    }
    void spawnWeapon()
    {
        Instantiate(weaponToSpawn, transform.position, weaponToSpawn.transform.rotation);
    }

   
}
