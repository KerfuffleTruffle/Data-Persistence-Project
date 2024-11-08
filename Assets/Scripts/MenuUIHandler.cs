using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour {

    public GameObject warningPanel;
    public TMP_InputField inputField;

    void Start() {
        
    }

    public void StartNew() {
        if (string.IsNullOrEmpty(MainManager.Instance.PlayerName)) {
            warningPanel.SetActive(true);
        } else {
            SceneManager.LoadScene(1);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Exit() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void InputFieldValueChanged() {
        MainManager.Instance.NewPlayerName(inputField.text);
    }
}
