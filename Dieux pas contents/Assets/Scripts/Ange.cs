using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;


public class Ange : MonoBehaviour
{
    public static Ange Instance;


    public Vector3 originalPos;
    public Vector3 newPos;

    private float timer;

    public Image ange;
    public Image boiteDialogue1;
    public Image boiteDialogue2;
    public TextMeshProUGUI text;

    private bool stop1;
    private bool stop2;

    private bool apparition;
    private float duree2;
    private string message2;


    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        boiteDialogue1.DOFade(0, 0);
        boiteDialogue2.DOFade(0, 0);

        text.DOFade(0, 0);

        ange.transform.DOLocalMoveX(720, 0);
    }


    private void Update()
    {
        if (apparition)
        {
            timer += Time.deltaTime;

            if (!stop1)
            {
                stop1 = true;
                ange.transform.DOLocalMoveX(550, 2);

                boiteDialogue1.DOFade(1, 2);
                boiteDialogue2.DOFade(1, 2);
                text.DOFade(1, 2);
            }

            else if (!stop2 && timer > 2 && timer < duree2)
            {
                stop2 = true;
                StartCoroutine(TypeSentence(message2));
            }

            else if (timer > duree2)
            {
                ange.transform.DOLocalMoveX(720, 2);

                boiteDialogue1.DOFade(0, 2);
                boiteDialogue2.DOFade(0, 2);
                text.DOFade(0, 2);

                apparition = false;
            }
        }
    }


    public void AngeApparait(string message, float duree)
    {
        apparition = true;
        duree2 = duree;
        message2 = message;

        timer = 0;
        stop1 = false;
        stop2 = false;
    }




    IEnumerator TypeSentence(string sentence)
    {
        text.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            text.text += letter;

            yield return new WaitForSeconds(0.03f);
        }
    }

    IEnumerator TypeSentenceLent(string sentence)
    {
        text.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            text.text += letter;

            yield return new WaitForSeconds(0.25f);
        }
    }
}
