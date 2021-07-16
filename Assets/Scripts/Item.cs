using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    // �̹��� ������Ʈ ȹ��
    [SerializeField] private ManualActionSO _activeSO;

    [SerializeField] private ActiveDialogSO _activeDialogSO;
    [SerializeField] private InventorySO _inventorySO;
    [SerializeField] private ItemSO _itemSO;

    private Image _itemImage;

    public Test test;

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
        var m = ScriptableObject.CreateInstance<ManualSO>();
        m.ManualData.Title = _itemSO.Name;
        m.ManualData.manual = _itemSO.Desc;
        m.ManualData.image = _itemSO.Image;
        _activeSO.activeAtion(m);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _activeSO.closeAction();
        //throw new System.NotImplementedException();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _inventorySO.Taken.Add(_itemSO);
        test.AddItem(_itemSO);

        var so = ScriptableObject.CreateInstance<SentencesSO>();

        so.Data.Title = "";
        so.Data.Sentences = new SentenceData[1];
        so.Data.Sentences[0].Sentence = $"{_itemSO.Name}을(를) 획득하였습니다.";

        _activeDialogSO.Active(so);
        

        Destroy(gameObject);
    }
}
