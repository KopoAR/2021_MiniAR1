using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace mv
{
    [System.Serializable]
    public struct NamedSkybox
    {
        public string Name;
        public Material Material;
    }

    [ExecuteInEditMode]
    public class SkyboxApplicator : MonoBehaviour
    {
        [SerializeField]
        private NamedSkybox[] _namedSkyboxs;

#if UNITY_EDITOR
        private int _correctSelection;
#endif

        [SerializeField]
        private int _selection;

        private void Awake()
        {
            if (_namedSkyboxs.Length > 0
                && _namedSkyboxs[_selection].Material != null)
            {
                ChangeSkybox();
            }
        }

        private void OnValidate()
        {
            if (_selection < _namedSkyboxs.Length
                && _namedSkyboxs[_selection].Material != null)
            {
                _correctSelection = _selection;
                ChangeSkybox();
            }
            else
            {
                _selection = _correctSelection;
                Debug.LogWarning("invalid skybox section.");
            }
        }

        private void ChangeSkybox() => RenderSettings.skybox = _namedSkyboxs[_selection].Material;
    }
}