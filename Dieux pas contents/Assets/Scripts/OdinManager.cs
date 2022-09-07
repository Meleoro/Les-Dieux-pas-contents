using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class OdinManager : MonoBehaviour
{
    public int Personne;

    public bool accepter;
    public bool refuser;
    public bool timer;

    public TextMeshProUGUI funnyText;
    public int textNumber;
    public GameObject gameOverScreen;

    public Image BouttonNON;
    public Image BouttonOUI;
    public Sprite imagepressOUI;
    public Sprite imagepressNON;
    public Sprite ogNON;
    public Sprite ogOUI;

    public GameObject Personnes;
    public GameObject Parchemins;
    public GameObject Bouttons;

    public Vector3 positionPersonnes;
    public Vector3 positionParchemins;

    private void Start()
    {
        Ange.Instance.AngeApparait("ELU !!!Vous le faites exprès ? Comment un élu de la prophécie peut-t-il être si incompétent !!", 3, 1, "Bref, ce n'est rien, vous pouvez encore vous ratrapez haha...", 2, 0,
            "Il est temps de trier des âmes. Naturellement, je ne vous apprend rien en disant que seuls les grands guerriers de ce monde peuvent accéder au Valhalla.", 3, 0,
            "Et pas les minables, morts de façon indigne. (je ne vous ai rien appris…n’est ce pas… ?)", 3, 0, "Aller courage elu, je crois en vous (je vais le tuer....)", 2, 0);

        StartCoroutine(WaitAnge());
        Bouttons.SetActive(false);
    }

    IEnumerator WaitAnge()
    {
        yield return new WaitForSeconds(11);
        PersonneSuivante();
    }

    private void Update()
    {

        if (Personne == 1)
        {
            if (accepter == true)
            {
                GameOver();
            }
            if (refuser == true)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }
        }

        if (Personne == 2)
        {
            if (accepter)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }
            if (refuser)
            {
                GameOver();
            }

        }

        if (Personne == 3)
        {
            if (accepter == true)
            {
                GameOver();
            }
            if (refuser == true)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }
        }

        if (Personne == 4)
        {
            if (accepter)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }
            if (refuser)
            {
                GameOver();
            }

        }

        if (Personne == 5)
        {
            if (accepter == true)
            {
                GameOver();
            }
            if (refuser == true)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }
        }

        if (Personne == 6)
        {
            if (accepter)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }
            if (refuser)
            {
                GameOver();
            }

        }

        if (Personne == 7)
        {
            MainManager.Instance.partie++;
            MainManager.Instance.SelectionDialogue();
        }
    }


    public void GameOver()
    {
        Personne = 0;
        Debug.Log("Mort");
        textNumber = Random.Range(0, 7);
            gameOverScreen.SetActive(true);
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

    public void Retart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void PersonneSuivante()
    {
        EventSystem.current.SetSelectedGameObject(null);
        accepter = false;
        refuser = false;
        Bouttons.SetActive(false);
        positionPersonnes = Personnes.transform.position;
        Personnes.transform.DOMoveX(positionPersonnes.x+1089,2);
        StartCoroutine(WaitChangement());
    }
    IEnumerator WaitChangement()
    {
        yield return new WaitForSeconds(2.5f);
        Personne += 1;
        DonneParch();
    }

    public void Accepter()
    {
        accepter = true;
    }

    public void Refuser()
    {
        refuser = true;
    }

    public void DonneParch()
    {
        positionParchemins = Parchemins.transform.position;
        Parchemins.transform.DOMoveY(positionParchemins.y-630, 1);
        Bouttons.SetActive(true);
    }

    public void ChangeSkinButtonNON()
    {
        BouttonNON.sprite = imagepressNON;
        StartCoroutine(Timer());
        BouttonNON.sprite = ogNON;
    }

    public void ChangeSkinButtonOUI()
    {
        BouttonOUI.sprite = imagepressOUI;
        StartCoroutine(Timer());
        BouttonOUI.sprite = ogOUI;
    }

    IEnumerator Timer()
    { 
        yield return new WaitForSeconds(0.3f);
    }
}



