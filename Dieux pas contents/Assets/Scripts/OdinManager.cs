using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class OdinManager : MonoBehaviour
{
    public int Personne;

    public bool accepter;
    public bool refuser;
    public bool timer;

    public GameObject Personnes;
    public GameObject Parchemins;
    public GameObject Bouttons;

    public Vector3 positionPersonnes;
    public Vector3 positionParchemins;

    private void Start()
    {
        PersonneSuivante();
        Bouttons.SetActive(false);
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
                GameOver();
                
            }
            if (refuser)
            {
                positionParchemins = Parchemins.transform.position;
                Parchemins.transform.DOMoveY(positionParchemins.y - 630, 1);
                PersonneSuivante();
            }

        }
    }


    public void GameOver()
    {
        Personne = 0;
        Debug.Log("Mort");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    void PersonneSuivante()
    {
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
}


