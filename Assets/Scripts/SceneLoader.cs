using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] SceneLoadType[] _sceneLoadTypes;

    public void Load()
    {
        if (_sceneLoadTypes.Length > 1 && _sceneLoadTypes.Any(x => x.LoadMode == LoadSceneMode.Single))
        {
            Debug.LogError("Multi scene loading is only possible in addtive mode");
            return;
        }

        foreach (var s in _sceneLoadTypes)
        {
            SceneManager.LoadSceneAsync(s.Scene, s.LoadMode);
        }
    }
}
