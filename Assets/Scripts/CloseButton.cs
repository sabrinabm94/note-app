using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    public GameObject exitPanel;

    public void CloseNote() {
        exitPanel.SetActive(true);
    }
}
