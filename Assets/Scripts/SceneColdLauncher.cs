using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

/// <summary>
/// �̹� �ε�Ǿ� �ִ��� Ȯ������ �ʴ� �ܼ� �ݵ己ó ��ũ��Ʈ 
/// �ε�� �������� �����ϰ� ���� �߰� ���θ� �ε��
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
