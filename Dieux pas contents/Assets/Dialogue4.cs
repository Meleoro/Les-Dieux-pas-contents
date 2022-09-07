using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Dialogue4 : MonoBehaviour
{
    private int numeroDialogue1;
    private int numeroDialogue2;

    public static Dialogue4 Instance;


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
            ReferencesUI.Instance.nom.text = "Téléphone";
            StartCoroutine(TypeSentence("Bzzz…Bzzz"));

            RefBackgrounds.Instance.valhalla.SetActive(false);
            RefBackgrounds.Instance.ciel.SetActive(true);

            RefChara.Instance.odinColere.SetActive(false);
            RefChara.Instance.odinHeureux.SetActive(false);
            RefChara.Instance.intiColere.SetActive(false);
            RefChara.Instance.intiContent.SetActive(false);
        }

        else if (numeroDialogue1 == 2)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Eh ben, bon travail, étonnamment, Odin est le seul qui ne t’ai pas fichu une rouste :0 ! "));
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.SetActive(true);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if(numeroDialogue1 == 3)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("La vieillesse l’as assagi visiblement. Oh et comment ils sont ces taxis célestes ? J’ai toujours voulu les essayer ^^.Eh ben, bon travail, étonnamment, Odin est le seul qui ne t’ai pas fichu une rouste :0 ! "));

        }

        else if(numeroDialogue1 == 4)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Bref, c’est ta chance ! Tu as un billet tout droit vers le Paradis o.O."));

        }

        else if(numeroDialogue1 == 5)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ne pense pas y aller pour couler des jours heureux. Ton objectif final t’y attend. Il est l’un des dieux les plus puissants, il ne faut surtout pas qu’il réponde à l’appel :( !"));

        }

        else if(numeroDialogue1 == 6)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Je veux parler de…"));

        }

        else if(numeroDialogue1 == 7)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Jésus Christ lui-même."));

        }

        else if(numeroDialogue1 == 8)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Par contre, pas de couverture cette fois-ci, l'endroit est vraiment trop bien protégé, impossible de trouver une faille :/…"));

        }

        else if (numeroDialogue1 == 9)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Tu devras l’affronter en face à face et le mettre KO."));
        }

        else if (numeroDialogue1 == 10)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Je suis sûr que tu en es capable, c'est ton moment ùwù !"));
        }

        else if (numeroDialogue1 == 11)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("N’oublie pas que je suis toujours à tes côtés <3."));
        }

        else if (numeroDialogue1 == 12)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("(J’ai toujours rêvé de dire ça à quelqu’un ^^)"));
        }

        else if (numeroDialogue1 == 12)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Bonne chance o/ !"));
        }

        else if (numeroDialogue1 == 13)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("J’aurais dû me douter que concubiner avec satan m'amènerait à combattre jésus. "));
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.Satan.SetActive(false);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.nous.SetActive(true);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if (numeroDialogue1 == 13)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Bon Bin… Ya plus qu’à ! Le voila !"));
        }

        else if (numeroDialogue1 == 14)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Bienvenue mon enfant, bienvenue au paradis."));
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.nous.SetActive(false);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.jesus.SetActive(true);
            RefChara.Instance.jesus.transform.DOMoveY(195,1);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if (numeroDialogue1 == 15)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Ici, je serais le berger qui guidera la brebis égarée que tu es."));
        }

        else if (numeroDialogue1 == 16)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Pas ici je vais te montrer ta nouvelle demeure. Suis moi brebis."));
        }

        else if (numeroDialogue1 == 17)
        {
            ReferencesUI.Instance.nom.text = "Téléphone";
            StartCoroutine(TypeSentence("Bzzz…Bzzz"));
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.jesus.SetActive(false);

        }

        else if (numeroDialogue1 == 18)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("C’est le moment, frappe le ou ça fait mal !"));
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.SetActive(true);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if (numeroDialogue1 == 19)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("AARGHH !"));
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.jesus.SetActive(true);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if (numeroDialogue1 == 20)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("…"));
        }

        else if (numeroDialogue1 == 21)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("…"));
        }

        else if (numeroDialogue1 == 22)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Qui ? QUI OSE ME PORTER ATTEINTE."));
            RefCamera.Instance.CameraShake(3f, 5f);
        }

        else if (numeroDialogue1 == 23)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Toi ? Je te reconnais… Tu es ce minable, le lèche bottes de satan."));
        }

        else if (numeroDialogue1 == 24)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("J’ai entendu ce que tu à fais à mes congénères et maintenant tu penses pouvoir t’en prendre à moi !!! "));
        }

        else if (numeroDialogue1 == 25)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Tu vas payer pour eux ! Voici ma vraie nature, mon vrai pouvoir !!!"));
        }

        else if (numeroDialogue1 == 26)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentence("Je sUiS Le bErGer qUi tE gUiDeRa, BrEbis ÉgArÉe."));
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.jesus.SetActive(false);
            RefChara.Instance.darkJesus.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.darkJesus.SetActive(true);
            RefChara.Instance.darkJesus.GetComponent<Image>().DOFade(1, 0.3f);
            RefCamera.Instance.CameraShake(3f, 5f);
            RefBackgrounds.Instance.cielDark.SetActive(true);
            RefBackgrounds.Instance.ciel.SetActive(false);
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
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("ImPoSsiBle !! J’Ai éTé vAiNcU pAR uNe bReBis éGaRéE !!!"));

            RefChara.Instance.darkJesus.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.darkJesus.SetActive(true);
            RefChara.Instance.darkJesus.GetComponent<Image>().DOFade(1, 0.3f);
            RefBackgrounds.Instance.cielDark.SetActive(true);
            RefCamera.Instance.CameraShake(3f, 5f);
        }

        else if(numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("C’EsT dOnC AinSi qUe leS tEmPs tOuChEnt à lEuRs FiN."));
        }

        else if (numeroDialogue2 == 3)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("Tu éTaiS cEnSé SaUvEr le mOnDe, pAs le déTrUiRe."));
        }

        else if (numeroDialogue2 == 4)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("Jeune brebis, dis moi, pourquoi te bats-tu ? D'où vient cette volonté de faire régner le chaos ?"));

            RefChara.Instance.darkJesus.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.darkJesus.SetActive(false);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.jesus.SetActive(true);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if (numeroDialogue2 == 5)
        {
            ReferencesUI.Instance.nom.text = "Téléphone";
            StartCoroutine(TypeSentenceLent("Bzzz…Bzzz"));

            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.jesus.SetActive(false);
        }

        else if (numeroDialogue2 == 6)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentenceLent("C’est fini Jésus, ma brebis ne te suivera pas, tu ne peux plus rien pour le monde, j’ai gagné :D !"));

            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.SetActive(true);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
        }

        else if (numeroDialogue2 == 7)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("C’est donc la fin…"));
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.Satan.SetActive(false);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.jesus.SetActive(true);
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(1, 0.3f);

        }

        else if (numeroDialogue2 == 8)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("(Comment je fais pour entendre des SMS ?)"));
        }

        else if (numeroDialogue2 == 9)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("Satan… Il y a du bon en toi, je le sais."));
        }

        else if (numeroDialogue2 == 10)
        {
            ReferencesUI.Instance.nom.text = "Jésus";
            StartCoroutine(TypeSentenceLent("Adieu..."));
            RefChara.Instance.jesus.GetComponent<Image>().DOFade(0, 0.5f);
            RefChara.Instance.jesus.SetActive(false);
        }

        else if (numeroDialogue2 == 11)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentenceLent("C’est bon on l'a fait, on a gagné !!! Bon travail /o/"));
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.Satan.SetActive(true);
        }

        else if (numeroDialogue2 == 12)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentenceLent("Le monde connaît maintenant le chaos ^^ !!"));
        }

        else if (numeroDialogue2 == 13)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentenceLent("Rejoins moi chez moi ! Je t’ai fait ces beignets que tu aimes tant ;D !"));
        }

        else if (numeroDialogue2 == 14)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentenceLent("Oh et j’ai réservé une table dans ton resto préféré ce soir !"));
        }

        else if (numeroDialogue2 == 15)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentenceLent("A ce soir <3 ! (haha j’ai hâte xP) "));
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

       // MainManager.Instance.noControl = false;
    }
}
