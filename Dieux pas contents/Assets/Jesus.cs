using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Jesus : MonoBehaviour
{
    public Rail rail;
    public static Jesus Instance;

    private int currentSeg;
    private float transition;

    private int nextSeg;

    public float JesusSpeed;

    public int health;
    public int currentHealth;
    private bool dying;


    [Header("Attaques")]
    public GameObject bullet;
    public GameObject bulletSpawner;
    private float timer1;
    private float timer2;
    private float timer3;


    public bool cantAttack;
    public bool surRail;
    public bool launchAnimation;
    public float timerGeneral;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentSeg = 1;

        currentHealth = health;


        surRail = false;
        cantAttack = true;
    }


    private void Update()
    {
        timerGeneral += Time.deltaTime;

        if(timerGeneral > 9 && timerGeneral < 10)
        {
            launchAnimation = true;
        }

        else if(timerGeneral > 10)
        {
            cantAttack = false;
            surRail = true;
        }


        if (surRail)
        {
            if (currentSeg == 6)
                nextSeg = 1;

            else
                nextSeg = currentSeg + 1;

            MouvementsJesus();
        }
        
        else if (launchAnimation)
        {
            transform.DOMoveY(0, 1);
        }

        



        // ATTAQUES
        if (!cantAttack)
        {
            timer1 += Time.deltaTime;
            if (timer1 > 0.03f)
            {
                Attaque1();
                timer1 = 0;
            }

            timer2 += Time.deltaTime;
            if (timer2 > 3 || (timer2 > 1.75f && currentHealth <= health / 2))
            {
                Attaque2();
                timer2 = 0;
            }

            timer3 += Time.deltaTime;
            if (timer3 > 7 || (timer3 > 3f && currentHealth <= health / 2))
            {
                Attaque3();
                timer3 = 0;
            }
        }


        // DEGATS
        if (currentHealth <= 0)
            dying = true;
    }





    public void MouvementsJesus()
    {
        transition += Time.deltaTime * JesusSpeed;

        if(transition > 1)
        {
            transition = 0;
            currentSeg++;
        }

        if (currentSeg == 7)
            currentSeg = 1;

        transform.position = rail.LinearPosition(currentSeg, nextSeg, transition);
    }


    void Attaque1()
    {
        for (int i = 0; i < 5; i++)
        {
            float modif = Random.Range(-2, 2);
            GameObject oui = Instantiate(bullet, transform.position, Quaternion.EulerAngles(0, 0, 90 + modif));

            Destroy(oui, 5f);
        }
    }

    void Attaque2()
    {
        for (int i = 0; i < 20; i++)
        {
            float modif = Random.Range(-4, 4);
            GameObject oui = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90 + modif));

            Destroy(oui, 5f);
        }
    }

    void Attaque3()
    {
        for (int i = 0; i < 50; i++)
        {
            float modif = Random.Range(-180, 180);
            GameObject oui = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90 + modif));

            Destroy(oui, 5f);
        }
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "JesusShot")
        {
            currentHealth -= 1;

            gameObject.transform.DOShakePosition(0.04f, 0.1f);
        }
    }

}
