using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public int score;
    public GameObject loseScreen;
    public TMP_Text scoreText;
    public bool lost = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Lose()
    {
        lost = true;
        loseScreen.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }
}
