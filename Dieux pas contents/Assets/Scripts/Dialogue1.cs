using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

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
            ReferencesUI.Instance.nom.text = "???";
            StartCoroutine(TypeSentence( "Garçon !"));

            RefChara.Instance.zeusHeureux.SetActive(false);
            RefChara.Instance.nous.SetActive(false);
            RefChara.Instance.ange.SetActive(false);
            RefChara.Instance.Satan.SetActive(false);


           // Ange.Instance.AngeApparait("Il est beau", 5);
        }

        else if (numeroDialogue1 == 2)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Moi et ma minette on aimerait commander."));
            RefChara.Instance.zeusHeureux.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.zeusHeureux.SetActive(true);
            RefChara.Instance.zeusHeureux.GetComponent<Image>().DOFade(1, 0.3f);
        }
        
        else if (numeroDialogue1 == 3)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence(" Filet de bœuf sauce ambroisie ? Cuisse de carpeaux au nectar ? Hmm je vois que la réputation de votre établissement n’est pas infondée."));
            
          
        }
        
        else if (numeroDialogue1 == 4)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Alors, qu’est ce qui te ferais plaisir mon petit cœur en sucre ?"));
            
      
        }
        
        else if (numeroDialogue1 == 5)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Après tout ce n’est pas parce que c’est l’apocalypse qu’il ne faut pas se faire plaisir."));
            
         
        }
        
        else if (numeroDialogue1 == 6)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("N’est-ce pas mon petit chouchou d’amour ?"));
            
           
        }
        
        else if (numeroDialogue1 == 7)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Servez-nous ce que vous avez de meilleur, Garçon. Montrez ce que votre établissement à de mieux à offrir. (J’espère pour vous que ça plaira à mon doudou en miel)."));
            
           
        }
        
        else if (numeroDialogue1 == 8)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("C'est à moi de jouer !"));
            RefChara.Instance.zeusHeureux.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.zeusHeureux.SetActive(false);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.nous.SetActive(true);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
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
            StartCoroutine(TypeSentence("Ahh merci garçon, c’est pas trop tôt, j’ai une faim de dieu hahaha."));
            
        }
        
        else if (numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Régale-toi ma chérie…"));
            
        }
        
        else if (numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentenceLent("…"));
            
        }

        else if(numeroDialogue2 == 3)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Pfffff !! Qu'est ce que c'est que ça !!??"));

            RefChara.Instance.zeusHeureux.SetActive(false);
            RefChara.Instance.zeusColere.SetActive(true);
        }

        else if(numeroDialogue2 == 4)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("J’ai jamais mangé quelque chose d’aussi répugnant !!"));
        }

        else if(numeroDialogue2 == 5)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Comment ose tu me servir ça à moi, Zeus, le dieu des dieux ?"));
        }

        else if(numeroDialogue2 == 6)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Je vais te faire regretter d’être venu au monde."));
        }

        else if(numeroDialogue2 == 7)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Et toi grognace ? Qu’est-ce que t’as à me regarder comme ça ? Tire-toi d’ici et que je te revois plus jamais !!!"));
        }

        else if(numeroDialogue2 == 8)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Quant à toi…"));
        }

        

        // Passage à la partie suivante
        else
        {
            MainManager.Instance.FermetureScene(3);

            MainManager.Instance.partie += 1;

            MainManager.Instance.transitionPerso = true;
        }
    }

    IEnumerator TypeSentence (string sentence)
    {
        ReferencesUI.Instance.dialogue.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            ReferencesUI.Instance.dialogue.text += letter;
          //  MainManager.Instance.noControl = true;

            yield return new WaitForSeconds(0.03f);
        }
        MainManager.Instance.noControl = false;
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
