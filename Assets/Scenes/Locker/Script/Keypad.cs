using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keypad : MonoBehaviour
{

    public GameObject objectToEnable;


    [Header("Keypad Settings")]
    public string[] curPassword;
    public string input;
    public Text displayText;
    public AudioSource failSound;
    public AudioSource collectSound;

    private bool keypadScreen;
    private float btnClicked = 0;
    private float numOfGuesses;



    void Start()
    {
        btnClicked = 0; 
        numOfGuesses = curPassword.Length; 
    }


    void Update()
    {
        if (btnClicked == numOfGuesses)
        {
            if (LockerManager.instance.on306 == true)
            {
                if (input == curPassword[0])
                {
                    //Load the next scene
                    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                    collectSound.Play();
                    input = "";
                    displayText.text = input.ToString();
                    btnClicked = 0;

                    Call306();
                }
                else
                {
                    input = "";
                    failSound.Play();
                    displayText.text = input.ToString();
                    btnClicked = 0;
                }
            }
           

            if (LockerManager.instance.on309 == true)
            {
                if (input == curPassword[1])
                {
                    collectSound.Play();
                    input = "";
                    displayText.text = input.ToString();
                    btnClicked = 0;

                    Call309();
                }
                else
                {
                    input = "";
                    failSound.Play();
                    displayText.text = input.ToString();
                    btnClicked = 0;
                }
            }


            if (LockerManager.instance.on311 == true)
            {
                if (input == curPassword[2])
                {
                    collectSound.Play();
                    input = "";
                    displayText.text = input.ToString();
                    btnClicked = 0;

                    Call311();
                }
                else
                {
                    input = "";
                    failSound.Play();
                    displayText.text = input.ToString();
                    btnClicked = 0;
                }
            }
            

            if (LockerManager.instance.on313 == true)
            {
                if (input == curPassword[3])
                {
                    collectSound.Play();
                    input = "";
                    displayText.text = input.ToString();
                    btnClicked = 0;

                    Call313();
                }
                else
                {
                    input = "";
                    failSound.Play();
                    displayText.text = input.ToString();
                    btnClicked = 0;
                }
            }
        }


    }


    void OnGUI()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("keypad"))
                {
                    keypadScreen = true;

                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        keypadScreen = true;
                    }
                }

            }
        }

        if (keypadScreen)
        {
            objectToEnable.SetActive(true);
        }

    }


    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q":
                objectToEnable.SetActive(false);
                btnClicked = 0;
                keypadScreen = false;
                input = "";
                displayText.text = input.ToString();
                break;

            case "C":
                input = "";
                btnClicked = 0;
                displayText.text = input.ToString();
                break;

            default: 
                btnClicked++; 
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }
    }


    public void Call306()
    {
        LockerManager.instance.Open306();
    }

    public void Call309()
    {
        LockerManager.instance.Open309();
    }

    public void Call311()
    {
        LockerManager.instance.Open311();
    }

    public void Call313()
    {
        LockerManager.instance.Open313();
    }

}
