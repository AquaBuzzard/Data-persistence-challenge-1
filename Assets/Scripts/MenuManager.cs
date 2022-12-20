using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
