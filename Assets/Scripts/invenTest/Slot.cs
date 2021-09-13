using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image itemImage;
    public GameObject Info;
    public Image infoImage;

    public bool slotFull=false;

    private void Start()
    {
        //infoImage = GetComponentInChildren<Image>();
        Info.SetActive(false);
    }

    public void AddSlot(ItemSO _item)
    {
        itemImage.sprite = _item.Image;
        slotFull = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        infoImage.sprite = itemImage.sprite;
        if(slotFull)
            Info.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Info.SetActive(false);
    }
}
