using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue2 : MonoBehaviour
{
    private int numeroDialogue1;
    private int numeroDialogue2;


    private void Awake()
    {
        numeroDialogue1 = 0;
        numeroDialogue2 = 0;
    }



    // FONCTION CONTENANT TOUS LES DIALOGUES AVANT LE MINI JEU
    public void AvancerDialogue1()
    {
        numeroDialogue1 += 1;

        if (numeroDialogue1 == 1)
        {
            ReferencesUI.Instance.nom.text = "Make Make";
            ReferencesUI.Instance.dialogue.text = "Pouahaha guerrier";

            RefChara.Instance.makeMakeContent.SetActive(true);
            RefChara.Instance.makeMakeColere.SetActive(false);

            RefChara.Instance.zeusColere.SetActive(false);
        }

        else if (numeroDialogue1 == 2)
        {
            ReferencesUI.Instance.nom.text = "Make Make";
            ReferencesUI.Instance.dialogue.text = "Diner";
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
            ReferencesUI.Instance.nom.text = "Make Make";
            ReferencesUI.Instance.dialogue.text = "OUI";

            RefChara.Instance.makeMakeContent.SetActive(false);
            RefChara.Instance.makeMakeColere.SetActive(true);
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
