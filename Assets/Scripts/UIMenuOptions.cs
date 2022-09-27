using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class UIMenuOptions : MonoBehaviour
{
    private string nameSelected;

    public void StartNew()
    {
        //Pull Current name.
        nameSelected = GameObject.Find("NameText").GetComponent<TextMeshProUGUI>().text;
        //code for saving name.
        DataManager.Instance.nameSelected = nameSelected;
        //This will load the main scene.
        SceneManager.LoadScene(1);
    }
}