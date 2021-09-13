using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceSuspect : MonoBehaviour
{
    public GameObject choiceBt;
    public GameObject suspectChoice;

    private void Start()
    {
        choiceBt.SetActive(true);
        suspectChoice.SetActive(false);
    }

    public void ClickChoice()
    {
        choiceBt.SetActive(false);
        suspectChoice.SetActive(true);
    }

}
