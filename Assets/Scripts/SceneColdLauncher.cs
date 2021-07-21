using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

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
            var sceneObj = SceneManager.GetSceneByName(s.Scene);
            if (sceneObj.isLoaded)
                continue;

            Debug.Log($"Scene[{s.Scene}] is cold launch.");
            
            SceneManager.LoadScene(s.Scene, LoadSceneMode.Additive);
            _OnLoaded?.Invoke(s);
        }
    }
}
