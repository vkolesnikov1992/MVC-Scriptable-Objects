using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    public Button button;
    public Image ItemIcon;

    private ItemData itemData;

    public void InitItem(ItemData item, Action<ItemData> callback)
    {
        itemData = item;
        ItemIcon.sprite = itemData.icon;

        button.onClick.AddListener(() => callback(itemData));
    }

    private void ButtonClicked()
    {
        Debug.Log(itemData.name);
    }
}