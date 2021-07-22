using UnityEngine;
using UnityEngine.Events;

public class SimpleStartSignal : MonoBehaviour
{
    [SerializeField] UnityEvent _onStart;

    private void Start()
    {
        _onStart?.Invoke();
    }
}
