using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitPainel : MonoBehaviour
{
    public GameObject exitPanel;
    public Button saveButton;
    public Button clearButton;

    void Start() {
        saveButton = GameObject.FindGameObjectWithTag("saveButton").GetComponent<Button>();
        clearButton = GameObject.FindGameObjectWithTag("clearButton").GetComponent<Button>();
    }

    void Update() {
        if(exitPanel.activeSelf == true) { 
            DisableButton();
        } else {
            ActiveButton();
        }
    }

    public void DisableButton() {
        //Debug.Log("DisableButton");
        saveButton.interactable = false;
        clearButton.interactable = false;
    }

    public void ActiveButton() {
        //Debug.Log("ActiveButton");
        saveButton.interactable = true;
        clearButton.interactable = true;
    }
}
