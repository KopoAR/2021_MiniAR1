using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleInventory : MonoBehaviour
{
    [SerializeField] private InputActionReference _toggleAction;
    [SerializeField] private GameObject _inventoryUI;
    [SerializeField] private InventorySO _inventorySO;
    [SerializeField] private GameObject _itemDisplayPrefab;
    [SerializeField] private GameObject _content;

    private void Start()
    {
        _inventoryUI.SetActive(false);
    }

    private void OnEnable()
    {
        _toggleAction.action.started += Toggle;
    }

    private void OnDisable()
    {
        _toggleAction.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        bool active = !_inventoryUI.activeSelf;
        _inventoryUI.SetActive(active);

        if (active)
        {
            foreach (var item in _inventorySO.Taken)
            {
                var prefab = Instantiate(_itemDisplayPrefab, _content.transform, false);
                var dp = prefab.GetComponent<ItemDisplay>();

                var so = ScriptableObject.CreateInstance<ManualSO>();
                so.ManualData.Title = item.Name;
                so.ManualData.manual = item.Desc;
                so.ManualData.image = item.Image;

                dp.ManualSO = so;
            }
        }
        else
        {
            foreach (Transform child in _content.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
