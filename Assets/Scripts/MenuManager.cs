using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.IO;
using TMPro;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MenuManager Instance;
    public MainManager mainManager;
    public TMP_InputField Name;  
    public TextMeshProUGUI HighScore;
    public string userName;
    public int score;
    private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    [System.Serializable]
    class SaveData{
       public string userName = Instance.Name.text;
       public string HighScore;
    }
    public void SaveHS(){
        SaveData data = new SaveData();
        data.HighScore = HighScore.text;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + " /savefile.json", json);
    }

    public void LoadHS(){
        string path = Application.persistentDataPath + " /savefile.json";

        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighScore.text = data.HighScore;
        }
    }
    
}
