using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LockerManager : MonoBehaviour
{
    public static LockerManager instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<LockerManager>();
            }
            return m_instance;
        }
    }

    private static LockerManager m_instance;    //싱글턴이 할당될 변수


    private bool keyOn = false;
    private bool openOn = false;

    public bool on306 = false;
    public bool on309 = false;
    public bool on311 = false;
    public bool on313 = false;



    public GameObject lockerPanel;

    public GameObject keyPanel;
    public GameObject bg306;
    public GameObject bg309;
    public GameObject bg311;
    public GameObject bg313;

    public GameObject keyCode;

    public GameObject openPanel;
    public GameObject open306;
    public GameObject open309;
    public GameObject open311;
    public GameObject open313;

    public GameObject exitBt;


    void Awake()
    {
        m_instance = this;
    }


    void Start()
    {
        keyOn = false;
        openOn = false;

        on306 = false;
        on309 = false;
        on311 = false;
        on313 = false;

    }



    void Update()
    {
        if (!keyOn && !openOn)
        {
            lockerPanel.SetActive(true);
            keyPanel.SetActive(false);
            openPanel.SetActive(false);
            exitBt.SetActive(false);

        }
        else if (!keyOn || openOn)
        {
            lockerPanel.SetActive(false);
            keyPanel.SetActive(false);
            openPanel.SetActive(true);
            exitBt.SetActive(true);

        }
        else if (keyOn || !openOn)
        {
            lockerPanel.SetActive(false);
            keyPanel.SetActive(true);
            openPanel.SetActive(false);
            exitBt.SetActive(true);

        }

    }


    public void Click306()
    {
        keyOn = true;
        openOn = false;
        on306 = true;

        bg306.SetActive(true);
        keyCode.SetActive(true);
    }


    public void Click309()
    {
        keyOn = true;
        openOn = false;
        on309 = true;

        bg309.SetActive(true);
        keyCode.SetActive(true);
    }


    public void Click311()
    {
        keyOn = true;
        openOn = false;
        on311 = true;

        bg311.SetActive(true);
        keyCode.SetActive(true);
    }


    public void Click313()
    {
        keyOn = true;
        openOn = false;
        on313 = true;

        bg313.SetActive(true);
        keyCode.SetActive(true);
    }


    public void Open306()
    {
        keyOn = false;
        openOn = true;

        open306.SetActive(true);
    }


    public void Open309()
    {
        keyOn = false;
        openOn = true;

        open309.SetActive(true);
    }


    public void Open311()
    {
        keyOn = false;
        openOn = true;

        open311.SetActive(true);
    }


    public void Open313()
    {
        keyOn = false;
        openOn = true;

        open313.SetActive(true);
    }


    public void Exit()
    {
        openPanel.SetActive(false);
        open306.SetActive(false);
        open309.SetActive(false);
        open311.SetActive(false);
        open313.SetActive(false);

        bg306.SetActive(false);
        bg309.SetActive(false);
        bg311.SetActive(false);
        bg313.SetActive(false);
        keyCode.SetActive(false);

        lockerPanel.SetActive(true);
        keyOn = false;
        openOn = false;
        on306 = false;
        on309 = false;
        on311 = false;
        on313 = false;

        exitBt.SetActive(false);

    }

}
