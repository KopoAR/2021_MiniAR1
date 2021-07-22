using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sounds
{
    public string name;
    public AudioClip clip;
}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] Sounds[] sfx = null;
    [SerializeField] Sounds[] bgm = null;

    [SerializeField] AudioSource[] bgmPlayer = null;
    [SerializeField] AudioSource[] sfxPlayer = null;

    private WaitForSeconds waitTime = new WaitForSeconds(0.01f);


    #region singleton
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion singleton



    private void Start()
    {
        instance = this;
    }

    public void PlayBGM(string p_bgmName)
    {
        for (int i = 0; i < bgm.Length; i++)
        {
            if (p_bgmName == bgm[i].name)
            {
                for (int j = 0; j < bgmPlayer.Length; j++)
                {
                    if (!bgmPlayer[j].isPlaying)
                    {
                        bgmPlayer[j].clip = bgm[i].clip;
                        bgmPlayer[j].Play();
                    }
                }
                Debug.Log("All BGM AudioSources are used");
                return;
            }
        }
        Debug.Log(p_bgmName + "is not existed");
    }

    //public void StopBGM()
    //{
    //    bgmPlayer.Stop();
    //}

    public void PlaySFX(string p_sfxName)
    {
        for (int i = 0; i < sfx.Length; i++)
        {
            if (p_sfxName == sfx[i].name)
            {
                for (int j = 0; j < sfxPlayer.Length; j++)
                {
                    if (!sfxPlayer[j].isPlaying)
                    {
                        sfxPlayer[j].clip = sfx[j].clip;
                        sfxPlayer[j].Play();
                        return;
                    }
                }
                Debug.Log("All SFX AudioSources are used");
                return;
            }
        }
        Debug.Log(p_sfxName + "is not existed");
    }
}
