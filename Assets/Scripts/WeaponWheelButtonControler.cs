using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponWheelButtonControler : MonoBehaviour
{
    public int ID;
    private Animator anim;
    public Image selectedItem;
    private bool selected = false;
    public Sprite Icon;
    public string itemName;
    public TextMeshProUGUI itemText;
    public TextMeshProUGUI ammoText;
    public string ammoNumber;
    AudioSource mySound;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        itemText.text = "";
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            //selectedItem.sprite = Icon;
            itemText.text = itemName;
            ammoText.text = ammoNumber;
        }
       
    }

    public void Selected()
    {
        
        selected = true;
        WeaponWheelContoller.weaponID = ID;
    }
    public void Deselected()
    {
        selected = false;
        WeaponWheelContoller.weaponID = 0;
        itemText.text = "";
        ammoText.text = "";
    }

    public void HoverEnter()
    {
        mySound = GetComponent<AudioSource>();
        mySound.Play();
        anim.SetBool("Hover", true);
        //itemText.text = itemName;
    }

    public void HoverExit()
    {
        anim.SetBool("Hover", false);
        itemText.text = "";
    }
}
