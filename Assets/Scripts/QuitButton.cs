using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public GameObject exitPanel;

    public void QuitApplication() {
        Application.Quit();
    }
}
