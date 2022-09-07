using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;
using UnityEngine.Rendering;


public class Ange : MonoBehaviour
{
    public static Ange Instance;

    public Volume volume;


    public Vector3 originalPos;
    public Vector3 newPos;

    private float timer;

    public Image ange;
    public Image boiteDialogue1;
    public Image boiteDialogue2;
    public TextMeshProUGUI text;

    private bool stop1;
    private bool stop2;
    private bool stop3;
    private bool stop4;
    private bool stop5;
    private bool stop6;

    private bool apparition;
    private float duree12;
    private float duree22;
    private float duree32;
    private float duree42;
    private float duree52;
    private string message12;
    private string message22;
    private string message32;
    private string message42;
    private string message52;

    private float shake12;
    private float shake22;
    private float shake32;
    private float shake42;
    private float shake52;


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
                ange.transform.DOLocalMoveX(500, 2);

                boiteDialogue1.DOFade(1, 2);
                boiteDialogue2.DOFade(1, 2);
                text.DOFade(1, 2);
            }

            else if (timer > 2 && timer < duree12 + duree22 + duree32 + duree42 + duree52 + 2)
            {
                if(timer < duree12 + 2 && !stop2)
                {
                    stop2 = true;
                    StartCoroutine(TypeSentence(message12));

                    RefCamera.Instance.CameraShake(duree12 / 2f, shake12);
                }

                else if(timer > duree12 + 2 && !stop3)
                {
                    stop3 = true;
                    StartCoroutine(TypeSentence(message22));

                    RefCamera.Instance.CameraShake(1, shake22);
                }

                else if(timer > duree12 + duree22 + 2 && !stop4)
                {
                    stop4 = true;
                    StartCoroutine(TypeSentence(message32));

                    RefCamera.Instance.CameraShake(duree32 / 2f, shake32);
                }

                else if (timer > duree12 + duree22 + duree32 + 2 && !stop5)
                {
                    stop5 = true;
                    StartCoroutine(TypeSentence(message42));

                    RefCamera.Instance.CameraShake(duree42 / 2f, shake42);
                }

                else if (timer > duree12 + duree22 + duree32 + duree42 + 2 && !stop6)
                {
                    stop6 = true;
                    StartCoroutine(TypeSentence(message52));

                    RefCamera.Instance.CameraShake(duree52 / 2f, shake52);
                }
            }

            else if (timer > duree12 + duree22 + duree32 + duree42 + duree52 + 2)
            {
                ange.transform.DOLocalMoveX(720, 2);

                boiteDialogue1.DOFade(0, 2);
                boiteDialogue2.DOFade(0, 2);
                text.DOFade(0, 2);

                apparition = false;
            }
        }
    }


    public void AngeApparait(string message1, float duree1, float shake1, string message2, float duree2, float shake2, string message3, float duree3, float shake3, string message4, float duree4, float shake4, 
        string message5, float duree5, float shake5)
    {
        apparition = true;

        text.text = "";

        duree12 = duree1;
        message12 = message1;
        shake12 = shake1;

        duree22 = duree2;
        message22 = message2;
        shake22 = shake2;

        duree32 = duree3;
        message32 = message3;
        shake32 = shake3;

        duree42 = duree4;
        message42 = message4;
        shake42 = shake4;

        duree52 = duree5;
        message52 = message5;
        shake52 = shake5;

        timer = 0;
        stop1 = false;
        stop2 = false;
        stop3 = false;
        stop4 = false;
        stop5 = false;
        stop6 = false;
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
