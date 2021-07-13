using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //[SerializeField] private InventorySO _inventorySO;
    private Image image;
    private void Awake()
    {
        //Debug.Assert(_inventorySO != null);
        image = GetComponent<Image>();
    }

    public void UpDateUI(Sprite i)
    {
        image.sprite = i;
    }
}
