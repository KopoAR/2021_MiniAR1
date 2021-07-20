using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

/// <summary>
/// 이미 로드되어 있는지 확인하지 않는 단순 콜드런처 스크립트 
/// 로드는 순차성을 보장하고 오직 추가 모드로만 로드됨
/// </summary>
public class SceneColdLauncher : MonoBehaviour
{
    [SerializeField] private SceneLoadType[] _sceneStack;
    [SerializeField] private UnityEvent<SceneLoadType> _OnLoaded;

    private void Start()
    {
        if (!Application.isEditor)
            return;

        foreach(var s in _sceneStack)
        {
            Debug.Log($"Scene[{s.Scene}] is cold launch.");
            
            SceneManager.LoadScene(s.Scene, LoadSceneMode.Additive);
            _OnLoaded?.Invoke(s);
        }
    }
}
