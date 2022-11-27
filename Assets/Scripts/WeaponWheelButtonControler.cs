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
    AudioSource mySound;
    

    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            selectedItem.sprite = Icon;
            itemText.text = itemName;
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
    }

    public void HoverEnter()
    {
        mySound = GetComponent<AudioSource>();
        mySound.Play();
        anim.SetBool("Hover", true);
        itemText.text = itemName;
    }

    public void HoverExit()
    {
        anim.SetBool("Hover", false);
        itemText.text = "";
    }
}
