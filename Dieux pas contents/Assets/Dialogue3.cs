using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
            RefBackgrounds.Instance.ilePaques.SetActive(false);
            ReferencesUI.Instance.nom.text = "T�l�phone";
            StartCoroutine(TypeSentence("Bzzz�Bzzz"));

            RefBackgrounds.Instance.valhalla.SetActive(true);

            RefChara.Instance.Satan.SetActive(false);
            RefChara.Instance.makeMakeColere.SetActive(false);
            RefChara.Instance.makeMakeContent.SetActive(false);
        }

        else if (numeroDialogue1 == 2)
        {
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.SetActive(true);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ouuups encore une bagarre :/."));
        }

        else if (numeroDialogue1 == 3)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ils sont vraiment pas commodes ces dieux, personne leur a appris les bonnes mani�res >:( ?"));
        }

        else if (numeroDialogue1 == 4)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("On va leur montrer de quel bois on se chauffe :[ ."));
        }

        else if (numeroDialogue1 == 5)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Toi visiblement c�est le bouleau, parce que tu fais du bon boulot XD."));
        }

        else if (numeroDialogue1 == 6)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("�"));
        }

        else if (numeroDialogue1 == 7)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Pardon� :'("));
        }

        else if (numeroDialogue1 == 8)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Bon bref, revenons � nos dieux. Regarde autour de toi. Bienvenue au Valhalla :D !"));
        }

        else if (numeroDialogue1 == 9)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Pas d�inqui�tude, tu es toujours en vie ^^. C�est moi qui t�ai d�pos� ici."));
        }

        else if (numeroDialogue1 == 10)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Tu trouveras ici ta prochaine cible : Odin. "));
        }

        else if (numeroDialogue1 == 11)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ce type est le chef du lieu, il est respect� de tous l� haut. Et c�est un vrai dur � cuire, tu comprendras en le voyant O.O."));
        }

        else if (numeroDialogue1 == 12)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("(Donc pr�pare toi � te prendre une racl�e :D)"));
        }

        else if (numeroDialogue1 == 13)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("*Message supprim�*"));
        }

        else if (numeroDialogue1 == 14)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ta couverture cette fois est un poste de douanier des �mes, le job de r�ve non X) ? "));
        }

        else if (numeroDialogue1 == 15)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ta mission, laisser entrer ou non les �mes dans le domaine du grand Odin :3."));
        }

        else if (numeroDialogue1 == 16)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Aller au travail, bonne chance soldat O7."));
        }

        else if (numeroDialogue1 == 17)
        {
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.Satan.SetActive(false);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.nous.SetActive(true);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("A moi de jouer !. Hmmm ? Une carrure imposante, un air sinistre... �a doit �tre lui."));
        }

        else if (numeroDialogue1 == 18)
        {
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.nous.SetActive(false);
            RefChara.Instance.odinColere.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.odinColere.SetActive(true);
            RefChara.Instance.odinColere.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("L�apocalypse fait des ravages, je vois que de nombreux guerriers arrivent aux portes de mon domaine. Mais que fait cette nouvelle recrue, les �mes commencent � s�impatienter."));
        }

        else if (numeroDialogue1 == 19)
        {
            RefChara.Instance.odinColere.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.odinColere.SetActive(false);
            RefChara.Instance.odinHeureux.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.odinHeureux.SetActive(true);
            RefChara.Instance.odinHeureux.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Ah vous voil�, je vous attendais. Prenez place je vous prie, j�imagine que vous vous y connaissez dans le domaine de la douane, vous travaillez au Paradis avant je me trompe ?"));
        }

        else if (numeroDialogue1 == 20)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Ce doit �tre un travail fatiguant, ce n�est pas digne d�un brave comme vous."));
        }

        else if (numeroDialogue1 == 21)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Pouahaha, ne serait ce pas Thor que je vois l� bas !"));
        }

        else if (numeroDialogue1 == 22)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Je dois y aller, le devoir m'appelle, vous ne savez pas ce que c�est de tenir un lieu de repos pour morts ? Pour vous donner une id�e, c�est encore pire qu�une EHPAD."));
        }

        else if (numeroDialogue1 == 23)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Bref, bon courage guerrier, � la revoyure !"));
        }

        // Passage � la partie suivante
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
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Qu�Qu'est ce que �a veut dire ?"));

            RefChara.Instance.intiContent.SetActive(false);
            RefChara.Instance.intiColere.SetActive(false);

            RefBackgrounds.Instance.valhalla.SetActive(true);
        }

        else if (numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Serait-ce des �mes de minables sans honneur ? Leur mort n�est m�me pas digne d�un chien. "));
        }

        else if(numeroDialogue2 == 3)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Douanier, des expliquations..."));
        }

        else if(numeroDialogue2 == 4)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("M�me vous n'�tes pas capable de faire votre travail� Je suis hautement d��u guerrier."));


        }

        else if(numeroDialogue2 == 5)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Vous avez ici perdu non seulement votre poste mais surtout votre honneur�"));


        }

        else if(numeroDialogue2 == 6)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Je vais vous renvoyer directement vers votre employeur. Plus jamais je n'embaucherai des douaniers du paradis (et j�irais toucher deux mots � ce J�sus Christ)."));

            RefChara.Instance.intiContent.SetActive(false);
            RefChara.Instance.intiColere.SetActive(true);
        }

        else if(numeroDialogue2 == 7)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("Je vais vous renvoyer directement vers votre employeur. Plus jamais je n'embaucherai des douaniers du paradis (et j�irais toucher deux mots � ce J�sus Christ)."));

            RefChara.Instance.intiContent.SetActive(false);
            RefChara.Instance.intiColere.SetActive(true);
        }

        else if(numeroDialogue2 == 8)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("D�guerpissez minable !"));

            RefChara.Instance.intiContent.SetActive(false);
            RefChara.Instance.intiColere.SetActive(true);
        }

        else if(numeroDialogue2 == 9)
        {
            ReferencesUI.Instance.nom.text = "Odin";
            StartCoroutine(TypeSentence("O, vous voulez peut-�tre que je vous appelle un taxi ? Bien sur je peux faire �a, aucun soucis. Bonne journ�e � vous !"));

            RefChara.Instance.odinColere.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.intiContent.SetActive(false);
            RefChara.Instance.odinColere.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.intiColere.SetActive(true);
            RefChara.Instance.odinColere.GetComponent<Image>().DOFade(1, 0.3f);
        }

        // Passage � la partie suivante
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

       // MainManager.Instance.noControl = false;
    }
}
