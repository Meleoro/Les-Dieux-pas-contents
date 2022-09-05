using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dialogue1 : MonoBehaviour
{
    private int numeroDialogue1;
    private int numeroDialogue2;

    public static Dialogue1 Instance;


    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
            Instance = this;

        else
            Destroy(gameObject);

        numeroDialogue1 = 0;
        numeroDialogue2 = 0;
    }



    // FONCTION CONTENANT TOUS LES DIALOGUES AVANT LE MINI JEU
    public void AvancerDialogue1()
    {
        numeroDialogue1 += 1;

        if(numeroDialogue1 == 1)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence( "Je suis beau ?!"));

            RefChara.Instance.zeusHeureux.SetActive(true);
        }

        else if (numeroDialogue1 == 2)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Oui oui vous avez raison !"));
        }

        // Passage à la partie suivante
        else
        {
            MainManager.Instance.partie += 1;
            MainManager.Instance.SelectionDialogue();
        }
    }


    // FONCTION CONTENANT TOUS LES DIALOGUES APRES LE MINI JEU
    public void AvancerDialogue2()
    {
        numeroDialogue2 += 1;

        if (numeroDialogue2 == 1)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentenceLent("Sthana"));

            RefChara.Instance.zeusHeureux.SetActive(false);
            RefChara.Instance.zeusColere.SetActive(true);

            RefCamera.Instance.CameraShake(0.5f, 5f);
        }

        // Passage à la partie suivante
        else
        {
            MainManager.Instance.numeroScript += 1;
            MainManager.Instance.partie = 1;

            RefChara.Instance.zeusColere.SetActive(false);
        }
    }

    IEnumerator TypeSentence (string sentence)
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

            yield return new WaitForSeconds(0.2f);
        }
    }
}
