using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BestScore
{
    public string name = "";
    public int points = 0;

    public static void SaveData()
    {
        BestScore bs = new BestScore();
        string json = JsonUtility.ToJson(bs);
        File.WriteAllText(Application.persistentDataPath + "/savedatafile.json", json);
    }

    public static BestScore LoadData()
    {
        string path = Application.persistentDataPath + "/savedatafile.json";
        Debug.Log(path);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<BestScore>(json);
        }
        return new BestScore();
    }
}
