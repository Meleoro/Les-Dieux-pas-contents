using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OdinManager : MonoBehaviour
{
    public int Personne;

    public bool accepter;
    public bool refuser;
    public bool timer;

    public GameObject Personnes;
    public GameObject Parchemin;
    public GameObject Bouttons;

    private void Start()
    {
        PersonneSuivante();
        Bouttons.SetActive(false);
    }

    private void Update()
    {
        Debug.Log(accepter);
    }

    public void GameOver()
    {
        Debug.Log("Mort");
    }


    void PersonneSuivante()
    {
        Bouttons.SetActive(false);
        accepter = false;
        refuser = false;
        Personne += 1;
        Personnes.transform.DOMoveX(1089,2);
        StartCoroutine(WaitChangement());
    }
    IEnumerator WaitChangement()
    {
        yield return new WaitForSeconds(2.5f);
        DonneParch();
    }

    public void Accepter()
    {
        accepter = true;
    }

    public void Refuser()
    {
        refuser= true;
    }

    public void DonneParch()
    {
        if(Personne == 1)
        {
            
            Parchemin.transform.DOMoveY(-605, 1);
            Bouttons.SetActive(true);
            if(accepter == true)
            {
                Debug.Log("oui");
                PersonneSuivante();
            }
            if (refuser == true)
            {
                GameOver();
            }

        }

        if (Personne == 2)
        {
            Parchemin.transform.DOMoveY(-605, 1);
            Bouttons.SetActive(true);
            if (accepter)
            {
                GameOver();
                accepter = false;
            }
            if (refuser)
            {
                PersonneSuivante();
                refuser = false;
            }

        }
    }
}


