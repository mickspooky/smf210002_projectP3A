using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelContoller : MonoBehaviour
{
    public Animator anim;
    private bool weaponWheelSelected = false;
    public Sprite noImage;
    public static int weaponID;
    public Image selectedItem;
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            weaponWheelSelected = !weaponWheelSelected;
        }
        if (weaponWheelSelected)
        {
            anim.SetBool("OpenWeaponWheel", true);
        }
        else
        {
            anim.SetBool("OpenWeaponWheel", false);
        }

        switch (weaponID)
        {
            case 0: //nothing is selcted
                selectedItem.sprite = noImage;
                break;
            case 1: //Fists
                Debug.Log("Fists");
                break;
            case 2: //Pistol
                Debug.Log("Pistol");
                break;
            case 3: //Shotgun
                Debug.Log("Shotgun");
                break;
            case 4: //Riffle
                Debug.Log("Riffle");
                break;
            case 5: //Rocket Launcher
                Debug.Log("Rocket Launcher");
                break;
            case 6: //Chainsaw
                Debug.Log("Chainsaw");
                break;
        }



    }
}
