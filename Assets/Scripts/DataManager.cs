using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string nameSelected;
    public string topName;
    public int topScore;
    private void Awake()
    {
        topName = "defualt";
        topScore = 0;
        //Insures only one of the object is caried over. Also refered to as a singleton.
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        //makes object aviable in any class and not destroy the object when a new scene is loaded.
        Instance = this;
        DontDestroyOnLoad(gameObject);
        //Load data
        LoadScore();
    }
    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.topScore = topScore;
        data.topName = nameSelected;
        topName = nameSelected;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            topScore = data.topScore;
            topName = data.topName;
        }
    }
    //data to save
    [System.Serializable]
    class SaveData
    {
        public string topName;
        public int topScore;
    }
}
