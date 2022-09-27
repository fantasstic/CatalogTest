using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Button _infoButton;

    public string Label => _label;
    public int Price => _price;
    public Sprite Sprite => _icon;

    public Button InfoButton => _infoButton;

}
