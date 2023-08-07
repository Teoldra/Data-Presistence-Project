using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public String UserName;
    public String Highscore;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        Load();
            
    }

    [System.Serializable]
    class SaveData
    {
        public String UserName;
        public String Highscore;
    }

    public void Save()
    {
        SaveData data = new()
        {
            UserName = UserName,
            Highscore = Highscore
        };

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            UserName = data.UserName;
            Highscore = data.Highscore;
            
        }
    }

}
