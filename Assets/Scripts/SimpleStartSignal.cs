using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SimpleStartSignal : MonoBehaviour
{
    [SerializeField] LaunchStateSO _launchStateSO;
    [SerializeField] UnityEvent _onStart;

    private void Start()
    {
        if (_launchStateSO.IsLaunched)
            return;

        _launchStateSO.IsLaunched = true;
        _onStart?.Invoke();
    }
}
