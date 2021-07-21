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

    private void Popup(ManualSO data)//, Vector3 pos)
    {
        title.text = data.ManualData.Title;
        manual.text = data.ManualData.manual;
        itemImage.sprite = data.ManualData.image;

       // panel.transform.position = new Vector3(pos.x, pos.y, pos.z);
       // panel.transform.rotation = Quaternion.Euler(new Vector3(0f, -pos.y, 0f));

        panel.SetActive(true);
    }

    private void PopupClose()
    {
        Debug.Log("close");
        panel.SetActive(false);
    }
}
