using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Intro : MonoBehaviour
{
    private int numeroDialogue;
    private Vector3 originalPos;


    private void Awake()
    {
        numeroDialogue = 0;
    }

    private void Start()
    {
        RefChara.Instance.nous.transform.DOScale(new Vector3(5, 5, 5), 0);

        originalPos = new Vector3(570, 260, 0);
    }



    // FONCTION CONTENANT TOUS LES DIALOGUES AVANT LE MINI JEU
    public void AvancerDialogue1()
    {
        numeroDialogue += 1;

        if (numeroDialogue == 1)
        {
            ReferencesUI.Instance.nom.text = "Elu de la prophétie";
            StartCoroutine(TypeSentence("Ca, c'est moi"));

            RefChara.Instance.nous.SetActive(true);
        }

        else if (numeroDialogue == 2)
        {
            ReferencesUI.Instance.nom.text = "Elu de la prophétie";
            StartCoroutine(TypeSentence("Le genre de gars sans histoire"));

            RefChara.Instance.nous.transform.DOScale(new Vector3(1, 1, 1), 10);
            RefChara.Instance.nous.transform.DOLocalMove(originalPos, 10);
        }

        // Passage à la partie suivante
        else
        {
            MainManager.Instance.numeroScript += 1;
            MainManager.Instance.numeroScript = 1;

            MainManager.Instance.SelectionDialogue();
        }
    }



    IEnumerator TypeSentence(string sentence)
    {
        ReferencesUI.Instance.dialogue.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            ReferencesUI.Instance.dialogue.text += letter;

            yield return new WaitForSeconds(0.03f);
        }
    }

    IEnumerator TypeSentenceLent(string sentence)
    {
        ReferencesUI.Instance.dialogue.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            ReferencesUI.Instance.dialogue.text += letter;
            MainManager.Instance.noControl = true;

            yield return new WaitForSeconds(0.25f);
        }

        MainManager.Instance.noControl = false;
    }
}
