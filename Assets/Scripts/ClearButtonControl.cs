using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearButtonControl : MonoBehaviour
{
    public GameObject noteText;
    public AudioSource clearSound;

    public void ClearNoteText() {
        noteText.GetComponent<InputField>().text = "";

        if (clearSound) {
            clearSound.Play();
        }
    }
}
