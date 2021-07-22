using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound
{
    public string soundName;
    public AudioClip clip;
}
public class soundManager : MonoBehaviour
{

    [SerializeField] Sound[] bgmSounds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
