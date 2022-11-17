using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelButtonControler : MonoBehaviour
{
    public int ID;
    private Animator anim;
    public Image selectedItem;
    private bool selected = false;
    public Sprite Icon;

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
        anim.SetBool("Hover", true);
    }

    public void HoverExit()
    {
        anim.SetBool("Hover", false);
    }
}
