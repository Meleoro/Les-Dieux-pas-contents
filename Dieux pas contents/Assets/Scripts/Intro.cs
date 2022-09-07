using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

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
        RefChara.Instance.nous.transform.DOScale(new Vector3(1.5f, 1.5f, 1.5f), 0);

        originalPos = new Vector3(589, 200, 0);
    }



    // FONCTION CONTENANT TOUS LES DIALOGUES AVANT LE MINI JEU
    public void AvancerDialogue1()
    {
        numeroDialogue += 1;

        if (numeroDialogue == 1)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Ça, c'est moi."));

            RefChara.Instance.nous.SetActive(true);
            RefBackgrounds.Instance.cielDark.SetActive(true);
        }

        else if (numeroDialogue == 2)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Un monsieur tout le monde."));
        }
        
        else if (numeroDialogue == 3)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Au beau milieu de L’Apocalypse, la fin des temps, là où toute chose, présente, passée et future, va disparaître."));


            // DEZOOM
            //RefBackgrounds.Instance.cielDark.DOScale(new(0.9f, 0.9f, 0.9f), 8);
            RefChara.Instance.nous.transform.DOScale(new Vector3(0.9f, 0.9f, 0.9f), 8);
            RefChara.Instance.nous.transform.DOLocalMove(originalPos, 10);
        }
        
        else if (numeroDialogue == 4)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Dans cet enfer, les humains ont perdu espoir mais les dieux, eux, allient leurs forces pour se battre contre le mal et sauver ce qui peut l’être."));
            
        }
        
        else if (numeroDialogue == 5)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Si tous les dieux parvenaient à se réunir, l’univers pourrait être sauvé."));
            
        }
        
        else if (numeroDialogue == 6)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Mais quelqu’un ferait tout pour éviter ça…"));
        }
        
        else if (numeroDialogue == 7)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Mon maître, Satan."));
        }
        
        else if (numeroDialogue == 8)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Enfin, mon maître... ça, c’est la version officielle, en réalité c’est plutôt mon… amoureux."));
        }
        
        else if (numeroDialogue == 9)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("C’est l'occasion parfaite de détruire le monde pour lui ! On a qu’à empêcher les dieux de se réunir pour regarder le chaos engloutir l'univers !"));
        }
        
        else if (numeroDialogue == 10)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("En plus de ça, Satan à fait joué de ses contacts pour que les dieux me prennent pour l'élu de la prophétie qui doit “sauver le monde”."));
        }
        
        else if (numeroDialogue == 11)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Avec ça, c’est dans la poche ! D’ailleur j’attend son appel, le plan devrait commencer d'une minute à l’autre..."));
        }
        
        else if (numeroDialogue == 12)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("Tiens qu'est ce que..."));
        }
        
        else if (numeroDialogue == 13)
        {
            ReferencesUI.Instance.nom.text = "Ange";
            StartCoroutine(TypeSentence("Hey Écoute !"));
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.nous.SetActive(false);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0.3f);
            RefChara.Instance.ange.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.ange.SetActive(true);
            RefChara.Instance.ange.GetComponent<Image>().DOFade(1, 0.3f);
            
            
        }
        
        else if (numeroDialogue == 14)
        {
            ReferencesUI.Instance.nom.text = "Ange";
            StartCoroutine(TypeSentence("C’est toi ! L’élu de la prophétie, mon maître m’a parlé de toi. (Il est plus moche que ce que je pensais...)"));
         
        }
        
        else if (numeroDialogue == 15)
        {
            ReferencesUI.Instance.nom.text = "Ange";
            StartCoroutine(TypeSentence("Il m'a envoyé à tes côtés pour t'aider à sauver le monde de l’Apocalypse."));
        }
        
        else if (numeroDialogue == 16)
        {
            ReferencesUI.Instance.nom.text = "Ange";
            StartCoroutine(TypeSentence("Il a placé de grands espoirs en toi alors ne le déçois pas. Après tout, ta mission est de la plus haute importance, le monde est en jeu."));
        }
        
        else if (numeroDialogue == 17)
        {
            ReferencesUI.Instance.nom.text = "Ange";
            StartCoroutine(TypeSentence("Alors fais de ton mieux ! Aller on part à l’aventure, je te suis !"));
        }
        
        else if (numeroDialogue == 18)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("(Ça a fonctionné ! Pas très fut fut les dieux...)"));
            RefChara.Instance.ange.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.ange.SetActive(false);
            RefChara.Instance.nous.SetActive(true);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
       
        }
        
        else if (numeroDialogue == 19)
        {
            ReferencesUI.Instance.nom.text = "Téléphone";
            StartCoroutine(TypeSentence("Bzzz…Bzzz"));
        }
        
        else if (numeroDialogue == 20)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Coucou ça va mon chou o/ ?"));
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.nous.SetActive(false);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.Satan.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.Satan.SetActive(true);
        }
        
        else if (numeroDialogue == 21)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("L’ange t’as rejoint ? Parfait, le plan peut commencer. J’ai trouvé l’occasion parfaite :0."));
        }
        
        else if (numeroDialogue == 22)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("J’ai appris que Zeus avait un rendez-vous avec une nouvelle amante (encore une, le coquin :X)."));
        }
        
        else if (numeroDialogue == 23)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Et devine quoi ! J’ai déniché un poste de serveur dans le restaurant où ils comptent aller ;) !"));
        }
        
        else if (numeroDialogue == 24)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Ta mission : gâcher leur date en leur servant le pire plat possible."));
        }
        
        else if (numeroDialogue == 25)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Le connaissant, il sera tellement en colère qu’il sera prêt à abandonner non seulement son date mais aussi l’univers tout entier XD"));
        }
        
        else if (numeroDialogue == 26)
        {
            ReferencesUI.Instance.nom.text = "Satan <3";
            StartCoroutine(TypeSentence("Bon je dois y aller j’ai hâte de voir ce que tu vas lui concocter. xoxo :3"));
        }

        // PASSAGE A LA PARTIE SUIVANTE
        else
        {

            MainManager.Instance.transitionPerso = true;

            MainManager.Instance.FermetureScene(3);
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
        //MainManager.Instance.noControl = false;

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

        //MainManager.Instance.noControl = false;
    }
}
