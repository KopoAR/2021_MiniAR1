using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private SceneLoadType[] _sceneLoadTypes;
    [SerializeField] private bool _unloadCurrentScene = true;
    
    private Scene _currentScene;

    public void Load()
    {
        if (_sceneLoadTypes.Length > 1 && _sceneLoadTypes.Any(x => x.LoadMode == LoadSceneMode.Single))
        {
            Debug.LogError("Multi scene loading is only possible in addtive mode");
            return;
        }

        _currentScene = SceneManager.GetActiveScene();
        foreach (var s in _sceneLoadTypes)
        {
            var op = SceneManager.LoadSceneAsync(s.Scene, s.LoadMode);
            op.allowSceneActivation = true;
            op.completed += (res) => {
                var loadedScene = SceneManager.GetSceneByName(s.Scene);
                SceneManager.SetActiveScene(loadedScene);

                if (_unloadCurrentScene)
                {
                    SceneManager.UnloadSceneAsync(_currentScene);
                    _unloadCurrentScene = false;
                }
            };
        }
    }
}