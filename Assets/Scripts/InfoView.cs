﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoView : MonoBehaviour
{
    public Image icon;
    public Text nameText;
    public Text typeText;
    public Text attackText;

    public void Init(ItemData data)
    {
        icon.sprite = data.icon;
        nameText.text = data.name;
        attackText.text = "Attack Power: " + data.attack;

        switch (data.type)
        {
            case ItemType.Axe: typeText.text = "Type: Axe"; break;
            case ItemType.Sword: typeText.text = "Type: Sword"; break;
            case ItemType.Bow: typeText.text = "Type: Bow"; break;
            case ItemType.FireScroll: typeText.text = "Type: FireScroll"; break;
        }
    }
}
