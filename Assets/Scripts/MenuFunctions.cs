using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuFunctions : MonoBehaviour
{
    public GameObject userInput;
    public Text nameUser;
    public void StartGame()
    {
        nameUser = userInput.GetComponent<Text>();
        GameManager.Instance.UserName = nameUser.text;
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
