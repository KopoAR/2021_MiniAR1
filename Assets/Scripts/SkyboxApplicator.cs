using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            ChangeSkybox(_selection);
        }

        private bool IsValidSelection(int index) => (index < _namedSkyboxs.Length) && (index >= 0) && (_namedSkyboxs[index].Material != null);

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (_namedSkyboxs.Length == 0)
                return;

            if (!IsValidSelection(_selection))
            {
                _selection = _correctSelection;
                Debug.LogWarning("invalid skybox section.");
                return;
            }

            _correctSelection = _selection;
            ChangeSkybox(_selection);
        }
#endif

        public void ChangeSkybox(int index)
        {
            if (!IsValidSelection(index))
                return;
            
            RenderSettings.skybox = _namedSkyboxs[index].Material;
        }

        public void ChangeSkybox(string name)
        {
            var found = _namedSkyboxs.FirstOrDefault(x => x.Name == name);
            if(found.Material != null)
                RenderSettings.skybox = found.Material;
        }
    }
}