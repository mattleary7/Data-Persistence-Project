using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    public GameObject nameInputField;
    string nameInput;

    public void StartNew()
    {
        
        nameInput = nameInputField.GetComponent<TMP_InputField>().text;

        PlayerData.Instance.playerName = nameInput;
        //Debug.Log(nameInput);

        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //MainManager.Instance.SaveColor();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    //public void SavePlayerName()
    //{
    //    MainManager.Instance.SaveColor();
    //}

    //public void LoadPlayerName()
    //{
    //    MainManager.Instance.LoadColor();
    //    ColorPicker.SelectColor(MainManager.Instance.TeamColor);
    //}
}
