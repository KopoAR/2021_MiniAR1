using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItemDisplay : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private ManualActionSO _activeManualSO;
    [SerializeField] private TextMeshProUGUI _text;

    private ManualSO _manualSO;
    public ManualSO ManualSO 
    {
        get => _manualSO; 
        set 
        {
            _manualSO = value;
            SetItem();
        } 
    }

    private void SetItem()
    {
        _text.text = _manualSO.ManualData.Title;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (ManualSO != null)
            _activeManualSO?.Active(ManualSO);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _activeManualSO?.closeAction();
    }
}
