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
    AudioSource mySound2;


    // Update is called once per frame

    public void Start()
    {
        mySound2 = GetComponent<AudioSource>();
        mySound2.Play();
    }
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
                Debug.Log("nothing selected");
                weaponID = 0;
                break;
            case 1: //Fists
                Debug.Log("Fists");
                weaponID = 1;
                break;
            case 2: //Pistol
                Debug.Log("Pistol");
                weaponID = 2;
                break;
            case 3: //Shotgun
                Debug.Log("Shotgun");
                weaponID = 3;
                break;
            case 4: //Riffle
                Debug.Log("Riffle");
                weaponID = 4;
                break;
            case 5: //Rocket Launcher
                Debug.Log("Rocket Launcher");
                weaponID = 5;
                break;
            case 6: //Chainsaw
                Debug.Log("Chainsaw");
                weaponID = 6;
                break;
        }



    }
}
