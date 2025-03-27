using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_Behaviour : MonoBehaviour
{
    public Button button;
    public string newScene;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        SceneManager.LoadScene(newScene);
    }

}
