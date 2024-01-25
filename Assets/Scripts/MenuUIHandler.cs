using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Exit(){
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else 
        Application.Quit();
        #endif
    }
}
