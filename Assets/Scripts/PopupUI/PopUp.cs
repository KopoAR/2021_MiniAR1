using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUp : MonoBehaviour
{
    [SerializeField] private ManualActionSO _manualAction;

    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private TextMeshProUGUI manual;
    [SerializeField] private Image itemImage;

    private void Awake()
    {
        Debug.Assert(_manualAction != null);
        Debug.Assert(panel != null);
        Debug.Assert(title != null);
        Debug.Assert(manual != null);
        Debug.Assert(itemImage != null);

        panel.SetActive(false);
        _manualAction.activeAtion += Popup;
        _manualAction.closeAction += PopupClose;
    }

    private void Popup(ManualSO data)
    {
        title.text = data.ManualData.Title;
        manual.text = data.ManualData.manual;
        itemImage.sprite = data.ManualData.image;
       

        panel.SetActive(true);
    }

    private void PopupClose()
    {
        panel.SetActive(false);
    }
}
