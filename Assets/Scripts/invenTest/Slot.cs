using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
    public Image itemImage;

    public bool slotFull=false;
    
    public void AddSlot(ItemSO _item)
    {
        itemImage.sprite = _item.Image;
        slotFull = true;
    }
}
