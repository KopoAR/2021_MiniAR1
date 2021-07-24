using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneColdLauncher : MonoBehaviour
{
    [SerializeField] private LaunchStateSO _launchStateSO;
    [SerializeField] private SceneLoadType[] _sceneStack;
    [SerializeField] private UnityEvent<SceneLoadType> _OnLoaded;

    private void Awake()
    {
        Debug.Assert(_launchStateSO != null);
    }

    private void Start()
    {
        if (_launchStateSO.IsColdLaunched)
            return;

        _launchStateSO.IsLaunched = true;
        _launchStateSO.IsColdLaunched = true;        

        foreach(var s in _sceneStack)
        {
            var sceneObj = SceneManager.GetSceneByName(s.Scene);
            if (sceneObj.isLoaded)
                continue;

            Debug.Log($"Scene[{s.Scene}] is cold launch.");
            
            SceneManager.LoadScene(s.Scene, LoadSceneMode.Additive);
            _OnLoaded?.Invoke(s);
        }
    }
}
