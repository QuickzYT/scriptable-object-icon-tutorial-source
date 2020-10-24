using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public ReadOnlyCollection<Item> ItemsSold => itemsSold.AsReadOnly();

    [SerializeField]
    private List<Item> itemsSold = new List<Item>();
}
