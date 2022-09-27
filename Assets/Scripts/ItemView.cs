using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemView : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;
    [SerializeField] private TMP_Text _price;
    [SerializeField] private Image _icon;
    [SerializeField] private Button _infoButton;
    private Item _item;

    public void Renderer(Item item)
    {
        _item = item;
        _label.text = item.Label;
        _price.text = item.Price.ToString() + '$';
        _icon.sprite = item.Sprite;
    }
}
