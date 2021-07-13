using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new inventory so", menuName = "Game/Inventory")]
public class InventorySO : ScriptableObject
{
    public List<ItemSO> Taken;

    private void Awake()
    {
        Taken = new List<ItemSO>();
    }
}
