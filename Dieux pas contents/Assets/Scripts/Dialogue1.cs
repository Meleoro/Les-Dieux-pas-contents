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
            StartCoroutine(TypeSentence( "Gar�on !"));

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
            StartCoroutine(TypeSentence(" Filet de b�uf sauce ambroisie ? Cuisse de carpeaux au nectar ? Hmm je vois que la r�putation de votre �tablissement n�est pas infond�e."));
            
          
        }
        
        else if (numeroDialogue1 == 4)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Alors, qu�est ce qui te ferais plaisir mon petit c�ur en sucre ?"));
            
      
        }
        
        else if (numeroDialogue1 == 5)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Apr�s tout ce n�est pas parce que c�est l�apocalypse qu�il ne faut pas se faire plaisir."));
            
         
        }
        
        else if (numeroDialogue1 == 6)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("N�est-ce pas mon petit chouchou d�amour ?"));
            
           
        }
        
        else if (numeroDialogue1 == 7)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Servez-nous ce que vous avez de meilleur, Gar�on. Montrez ce que votre �tablissement � de mieux � offrir. (J�esp�re pour vous que �a plaira � mon doudou en miel)."));
            
           
        }
        
        else if (numeroDialogue1 == 8)
        {
            ReferencesUI.Instance.nom.text = "Elu";
            StartCoroutine(TypeSentence("C'est � moi de jouer !"));
            RefChara.Instance.zeusHeureux.GetComponent<Image>().DOFade(1, 0.3f);
            RefChara.Instance.zeusHeureux.SetActive(false);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(0, 0);
            RefChara.Instance.nous.SetActive(true);
            RefChara.Instance.nous.GetComponent<Image>().DOFade(1, 0.3f);
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
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Ahh merci gar�on, c�est pas trop t�t, j�ai une faim de dieu hahaha."));
            
        }
        
        else if (numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("R�gale-toi ma ch�rie�"));
            
        }
        
        else if (numeroDialogue2 == 2)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentenceLent("�"));
            
        }

        else if(numeroDialogue2 == 3)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Pfffff !! Qu'est ce que c'est que �a !!??"));

            RefChara.Instance.zeusHeureux.SetActive(false);
            RefChara.Instance.zeusColere.SetActive(true);
        }

        else if(numeroDialogue2 == 4)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("J�ai jamais mang� quelque chose d�aussi r�pugnant !!"));
        }

        else if(numeroDialogue2 == 5)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Comment ose tu me servir �a � moi, Zeus, le dieu des dieux ?"));
        }

        else if(numeroDialogue2 == 6)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Je vais te faire regretter d��tre venu au monde."));
        }

        else if(numeroDialogue2 == 7)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Et toi grognace ? Qu�est-ce que t�as � me regarder comme �a ? Tire-toi d�ici et que je te revois plus jamais !!!"));
        }

        else if(numeroDialogue2 == 8)
        {
            ReferencesUI.Instance.nom.text = "Zeus";
            StartCoroutine(TypeSentence("Quant � toi�"));
        }

        

        // Passage � la partie suivante
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
