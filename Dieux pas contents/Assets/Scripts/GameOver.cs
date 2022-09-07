using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static GameOver Instance;


    public GameObject gameOverScreen;
    public GameObject gameUI;
    public TextMeshProUGUI funnyText;
    public int textNumber;
    public bool Lost = false;

    public bool setScreen = false;

    void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        gameOverScreen.SetActive(false);
    }


    public void LoseGame()
    {
        textNumber = Random.Range(0, 7);
        gameOverScreen.SetActive(true);
        //gameUI.SetActive(false);

        Debug.Log(textNumber);

        if (textNumber == 0)
        {
            funnyText.text = "Vous ferez moins bien la prochaine fois!";
        }
        else if (textNumber == 1)
        {
            funnyText.text = "Essayez moins fort!";
        }
        else if (textNumber == 2)
        {
            funnyText.text = "Ne vous donnez pas à 100%!";
        }
        else if (textNumber == 3)
        {
            funnyText.text = "Essayez de ne pas essayer!";
        }
        else if (textNumber == 4)
        {
            funnyText.text = "Arrêtez d'être aussi bon!";
        }
        else if (textNumber == 5)
        {
            funnyText.text = "Ne vous dépassez surtout pas!";
        }
        else if (textNumber == 6)
        {
            funnyText.text = "Cessez le tryhard!";
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseTuto()
    {
        Time.timeScale = 0;
        //Use unscaled time for dialogue.
    }

    public void ResumeTuto()
    {
        Time.timeScale = 1;
    }
}




    


