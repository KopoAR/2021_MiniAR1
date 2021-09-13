using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlay : MonoBehaviour
{
    private BGMManager bgmManager;
    public int bgmNum;


    void Start()
    {
        StartCoroutine(TryPlayBGM());
    }

    private IEnumerator TryPlayBGM()
    {
        while (BGMManager.instance == null)
        {
            yield return new WaitForFixedUpdate();
        }

        bgmManager = BGMManager.instance;
        PlayBGM(bgmNum);
    }

    public void PlayBGM(int n)
    {
        bgmManager.Play(n);
        bgmManager.SetVoulme(0.2f, n);
    }
}
