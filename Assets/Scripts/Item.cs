using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // ÀÌ¹ÌÁö ÄÄÆ÷³ÍÆ® È¹µæ

    [SerializeField] private ActiveDialogSO _activeDialogSO;
    [SerializeField] private InventorySO _inventorySO;
    [SerializeField] private ItemSO _itemSO;

    [SerializeField] private Inventory inven;

    private Image _itemImage;


    private void Awake()
    {
        Debug.Assert(_inventorySO != null);
        Debug.Assert(_itemSO != null);
        Debug.Assert(_activeDialogSO != null);

       _itemImage = GetComponent<Image>();
    }

    private void Start()
    {
        _itemImage.sprite = _itemSO.Image;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _inventorySO.Taken.Add(_itemSO);
        inven.UpDateUI(_itemSO.Image);

        var so = ScriptableObject.CreateInstance<SentencesSO>();

        so.Data.Title = "";
        so.Data.Sentences = new SentenceData[1];
        so.Data.Sentences[0].Sentence = $"{_itemSO.Name}¸¦ È¹µæÇß´Ù.";

        _activeDialogSO.Active(so);

        Destroy(gameObject);
    }
}
