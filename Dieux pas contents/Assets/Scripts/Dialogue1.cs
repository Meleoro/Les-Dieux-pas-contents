using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue1 : MonoBehaviour
{
    private int numeroDialogue1;
    private int numeroDialogue2;

    [Header("References")]
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI nom;


    public void AvancerDialogue1()
    {
        numeroDialogue1 += 1;

        if(numeroDialogue1 == 1)
        {
            nom.text = "Zeus";
            dialogue.text = "Je suis beau ?!";
        }

        else if (numeroDialogue1 == 2)
        {
            nom.text = "Zeus";
            dialogue.text = "Oui oui vous avez raison !";
        }

        else
        {
            MainManager.Instance.partie = 2;
        }
    }

    public void AvancerDialogue2()
    {
        numeroDialogue2 += 1;

        if (numeroDialogue2 == 1)
        {

        }

        else
        {
            MainManager.Instance.numeroScript += 1;
            MainManager.Instance.partie = 1;
        }
    }
}
