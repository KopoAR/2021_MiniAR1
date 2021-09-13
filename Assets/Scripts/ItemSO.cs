using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new item so", menuName = "Game/Item")]
public class ItemSO : ScriptableObject
{
    public string Name;
    public string Desc;
    public Sprite Image;
}
