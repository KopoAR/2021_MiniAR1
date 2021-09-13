using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance
    {
        get
        {
            if(i_instance==null)
            {
                i_instance = FindObjectOfType<ItemManager>();
            }
            return i_instance;
        }
    }
    private static ItemManager i_instance;

    public int itemCount { get; private set; }

    private void Awake()
    {
        if(instance!=this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public void ItemCountAdd() //void
    {   //아이템 카운트 증가
        Debug.Log(itemCount);
        ++itemCount;
    }
}
