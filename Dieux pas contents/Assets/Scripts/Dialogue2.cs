using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
            ReferencesUI.Instance.nom.text = "Téléphone";
            ReferencesUI.Instance.dialogue.text = "Bzzz…Bzzz";

           RefBackgrounds.Instance.ilePaques.SetActive(true);
            RefBackgrounds.Instance.restoFlou.SetActive(false);
            RefBackgrounds.Instance.resto.SetActive(false);

            RefChara.Instance.makeMakeColere.SetActive(false);
            RefChara.Instance.zeusColere.SetActive(false);
        }

        else if (numeroDialogue1 == 2)
        {
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.SetActive(true);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ehh rien de cassé ? :O"));
        }

        else if (numeroDialogue1 == 3)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Il t’en a collé une bonne ! J’aimerais pas prendre une droite de Zeus. ^^"));
        }

        else if (numeroDialogue1 == 4)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Mais bon t’as fait du bon travail, avec ça, jamais il ne rejoindra les autres dieux."));
        }

        else if (numeroDialogue1 == 5)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Bien, notre travail n’est pas terminé, il nous reste du pain sur la planche >:/ !"));
        }

        else if (numeroDialogue1 == 6)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Je t’ai envoyé te reposer sur l’île de pâque près de domaine de Make Make, c’est ta prochaine cible (me demande pas comment :3)."));
        }


        else if (numeroDialogue1 == 7)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Make make était autrefois le dieu le plus important de l’île de pâque."));
        }


        else if (numeroDialogue1 == 8)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Mais étant aujourd’hui un dieu oublié des humains, il s’est éloigné des activités divines. Son activité principale est de récolter des œufs divins pour les villages locaux."));
        }

        else if (numeroDialogue1 == 9)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Mais il n’en reste pas moins puissant, il est donc un danger pour nous. Brise ses œufs, ils lui sont si précieux qu’il n’acceptera pas de suivre les autres dieux."));
        }

        else if (numeroDialogue1 == 10)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Encore une fois, ne crains rien, je t’ai trouvé une couverture parfaite. Il pense que tu es un pèlerin venu pour se recueillir dans son domaine."));
        }

        else if (numeroDialogue1 == 11)
        {
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.Satan.SetActive(false);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.nous.SetActive(true);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Hihi, il est trop mignon !"));
        }

        else if (numeroDialogue1 == 12)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Argh, pour qui il se prend ce Zeus ? Il m'a vraiment bien amoché."));
        }

        else if (numeroDialogue1 == 13)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Bon aller j'ai du travail. Eh mais, là bas, ça ne serait pas..."));
        }

        else if (numeroDialogue1 == 14)
        {
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.nous.SetActive(false);
            RefChara.Instance.makeMakeColere.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.makeMakeColere.SetActive(true);
            RefChara.Instance.makeMakeColere.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Que faites-vous dans domaine de Make-Make ? PARTEZ TOUT DE SUITE !!"));
        }

        else if (numeroDialogue1 == 15)
        {
            RefChara.Instance.makeMakeColere.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.makeMakeColere.SetActive(false);
            RefChara.Instance.makeMakeContent.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.makeMakeContent.SetActive(true);
            RefChara.Instance.makeMakeContent.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Ohh toi pèlerin. Make Make entendu parler toi. Entre pèlerin."));
        }

        else if (numeroDialogue1 == 16)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Make-Make très content recevoir pèlerin, Make-Make pas beaucoup avoir visiteurs."));
        }

        else if (numeroDialogue1 == 17)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Make-Make vous faire confidence donc Make-Make vous montrer quelque chose."));
        }

        else if (numeroDialogue1 == 18)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Ici sont œufs divins de Make-Make. oeufs divins sont très importants. Make-Make etre sur le point de les récolter, œufs vont bientôt éclore."));
        }

        else if (numeroDialogue1 == 19)
        {
            ReferencesUI.Instance.nom.text = "Villageois";
            StartCoroutine(TypeSentence("Ô grand Make-Make, aidez-nous !"));
        }

        else if (numeroDialogue1 == 20)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Qui interrompre Make-Make ?"));
        }

        else if (numeroDialogue1 == 21)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Le village est attaqué par des démons de l’Apocalypse. Vous devez nous venir en aide et nous prêter votre force ô vénérable Make-Make."));
        }

        else if (numeroDialogue1 == 22)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Hmmm… très bien Make-Make va aider Villageois. Avant ça, Make-Make confier tâche à Pèlerin."));
        }

        else if (numeroDialogue1 == 23)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Pèlerin récolter œufs sacrés et faire attention à pas casser œufs. Sinon Make-Make boom boom Pèlerin."));
        }

        else if (numeroDialogue1 == 24)
        {
            RefChara.Instance.makeMakeContent.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.makeMakeContent.SetActive(false);
            ReferencesUI.Instance.nom.text = "Téléphone";
            StartCoroutine(TypeSentence("Bzzz…Bzzz"));
        }

        else if (numeroDialogue1 == 25)
        {
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.SetActive(true);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Tu me remercieras plus tard ;)"));
            RefBackgrounds.Instance.ilePaques.SetActive(false);
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
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Make-Make boom boom démons."));

            RefBackgrounds.Instance.ilePaques.SetActive(true);

            RefChara.Instance.makeMakeContent.SetActive(true);
            RefChara.Instance.makeMakeColere.SetActive(false);
        }

        if (numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Pellerin récolté œufs ?"));
        }

        if (numeroDialogue2 == 3)
        {
            RefChara.Instance.makeMakeContent.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.makeMakeContent.SetActive(false);
            RefChara.Instance.makeMakeContent.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.makeMakeColere.SetActive(true);
            RefChara.Instance.makeMakeColere.GetComponent<Image>().DOFade(1, 0.3f);

            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Qu’est-ce que ? Œufs cassés ?"));
        }

        if (numeroDialogue2 == 4)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("PELERIN BOOM BOOM ŒUFS ?"));
        }

        if (numeroDialogue2 == 5)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("Après tout ce que Make-Make a fait pour avoir œufs, le pèlerin boom boom tout travail de Make-Make."));
        }

        if (numeroDialogue2 == 6)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("MAKE-MAKE VAS BOOM BOOM BOOOOOM LE PELERIN !!!"));
        }

        if (numeroDialogue2 == 7)
        {
            ReferencesUI.Instance.nom.text = "Make-Make";
            StartCoroutine(TypeSentence("AHHHH BOOM BOOOOM !!"));
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
           // MainManager.Instance.noControl = true;

            yield return new WaitForSeconds(0.03f);
        }
    }

    IEnumerator TypeSentenceLent(string sentence)
    {
        ReferencesUI.Instance.dialogue.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            ReferencesUI.Instance.dialogue.text += letter;
           // MainManager.Instance.noControl = true;

            yield return new WaitForSeconds(0.25f);
        }

       // MainManager.Instance.noControl = false;
    }
}
