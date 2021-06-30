using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public string noteText;
    public string titleText;
    public GameObject note;
    public GameObject title;
    public GameObject noteInput;
    public GameObject titleInput;
    public GameObject saveConfirmationText;

    void Start()
    {
        LoadNote();
    }

    public void LoadNote() {
        noteText = PlayerPrefs.GetString("NoteTextContent");
        titleText = PlayerPrefs.GetString("NoteTitleContent");
        noteInput.GetComponent<InputField>().text = noteText;
        titleInput.GetComponent<InputField>().text = titleText;
    }

    public void SaveNote() {
        noteText = note.GetComponent<Text>().text;
        titleText = title.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteTextContent", noteText);
        PlayerPrefs.SetString("NoteTitleContent", titleText);
        StartCoroutine(SaveConfirmation());
    }

    IEnumerator SaveConfirmation() {
        saveConfirmationText.GetComponent<Animator>().Play("SaveConfirmation");
        yield return new WaitForSeconds(1);
        saveConfirmationText.GetComponent<Animator>().Play("New State");
    }
}
