using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Slot[] slot;
    public void AddItem(ItemSO _item)
    {
        for (int i = 0; i < slot.Length; i++)
        {
            if (!slot[i].slotFull && _item != null)
            {
                Debug.Log(i);
                slot[i].AddSlot(_item);
                return;
            }
        }
    }
}
