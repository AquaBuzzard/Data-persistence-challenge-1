using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;


public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    public TextMeshProUGUI bestScoreText;
    public Button startButton;
    public Button exitButton;
    public TMP_InputField nameInputField;
    public string playerName;

    public void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        
       
    }

    // Start is called before the first frame update
    void Start()
    {
        BestScore bestScore = BestScore.LoadData();
        bestScoreText.text = $"Best Score  : {bestScore.name} : {bestScore.points}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void GetPlayerName()
    {
       playerName =  nameInputField.text;
        
    }

   
}
