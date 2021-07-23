using UnityEngine;
using UnityEngine.Events;

public class SimpleStartSignal : MonoBehaviour
{
    [SerializeField] UnityEvent _onStart;
    [SerializeField] ColdLaunchSO _coldLaunchSO;
    private void Start()
    {
#if !UNITY_EDITOR
        _coldLaunchSO.isColdLaunch = false;
#endif

        if (!_coldLaunchSO.isColdLaunch)
            _onStart?.Invoke();
    }
}
