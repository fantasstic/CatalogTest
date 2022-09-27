using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Item> _items;
    [SerializeField] private ItemView _template;
    [SerializeField] private GameObject _itemContainer;

    private void Start()
    {
        for(int i = 0; i < _items.Count; i++)
        {
            AddItem(_items[i]);
        }
    }

    private void AddItem(Item item)
    {
        var view = Instantiate(_template, _itemContainer.transform);
        view.Renderer(item);
    }
}
