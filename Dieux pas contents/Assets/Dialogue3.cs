using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue3 : MonoBehaviour
{
    private int numeroDialogue1;
    private int numeroDialogue2;

    public static Dialogue3 Instance;


    private void Awake()
    {
        Instance = this;

        numeroDialogue1 = 0;
        numeroDialogue2 = 0;
    }



    // FONCTION CONTENANT TOUS LES DIALOGUES AVANT LE MINI JEU
    public void AvancerDialogue1()
    {
        numeroDialogue1 += 1;

        if (numeroDialogue1 == 1)
        {
            ReferencesUI.Instance.nom.text = "Inti";
            StartCoroutine(TypeSentence("Je suis beau ?!"));

            RefChara.Instance.intiContent.SetActive(true);

            RefChara.Instance.makeMakeColere.SetActive(false);
        }

        else if (numeroDialogue1 == 2)
        {
            ReferencesUI.Instance.nom.text = "Inti";
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
            ReferencesUI.Instance.nom.text = "Inti";
            StartCoroutine(TypeSentenceLent("Sthana"));

            RefChara.Instance.intiContent.SetActive(false);
            RefChara.Instance.intiColere.SetActive(true);
        }

        // Passage à la partie suivante
        else
        {
            MainManager.Instance.FermetureScene(3);

            MainManager.Instance.partie += 1;

            MainManager.Instance.transitionPerso = true;
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
