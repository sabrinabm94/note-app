using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public int introScene = 1;
    public int notesSelectionScene = 0;
    public int selectedNoteScene = 0;

    void Start()
    {
        StartCoroutine(MoveToNextScene());
    }

    IEnumerator MoveToNextScene() {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(selectedNoteScene);
    }
}
