using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CancelButton : MonoBehaviour
{
    public GameObject exitPanel;

    public void CancelExitPainel() {
        exitPanel.SetActive(false);
    }
}
