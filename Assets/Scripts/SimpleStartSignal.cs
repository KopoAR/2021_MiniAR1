using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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
        {
            _onStart?.Invoke();
            return;
        }

        if(SceneManager.sceneCount == 1)
            _onStart?.Invoke();
    }
}
