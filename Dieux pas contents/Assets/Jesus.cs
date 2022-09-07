using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Jesus : MonoBehaviour
{
    public Rail rail;
    public static Jesus Instance;
    public Rigidbody2D rb;

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
    public bool phase2;


    public bool cantAttack;
    public bool surRail;
    public bool launchAnimation;
    public float timerGeneral;


    private bool stop;
    private bool stop2;
    public float cooldownPhase2;
    private float timerPhase2;

    [Header("Ghost Effect")]
    public float ghostCooldown;
    public GameObject ghost;
    private float timerGhost;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        currentSeg = 1;

        currentHealth = health;

        RefBackgrounds.Instance.cielDark.SetActive(false);


        surRail = false;
        cantAttack = true;
    }


    private void Update()
    {
        timerGeneral += Time.deltaTime;

        if (currentHealth <= health / 2 && !stop)
        {
            timerGeneral = 0;
            phase2 = true;

            cantAttack = true;
            surRail = false;

            currentHealth += 100;
            stop = true;
        }


        if (!phase2)
        {
            if (timerGeneral > 25 && timerGeneral < 26)
            {
                launchAnimation = true;
            }

            else if (timerGeneral > 26)
            {
                cantAttack = false;
                surRail = true;
            }
        }

        else if(!stop2)
        {
            if(timerGeneral == 0)
            {
                transform.DOMove(new Vector2(9, 0), 1);
                transform.DOShakePosition(1, 1);
            }

            else if(timerGeneral >= 1)
            {
                cantAttack = false;
                surRail = true;

                currentSeg = 1;
                transition = 0;

                JesusSpeed = 3.5f;

                timer3 = 10;
                timerPhase2 = 0;
                rb.velocity = Vector2.zero;

                stop2 = true;
            }
        }


        // GHOST EFFECT
        timerGhost += Time.deltaTime;

        if (timerGhost > ghostCooldown && phase2)
        {
            timerGhost = 0;

            GameObject clone = Instantiate(ghost, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
        }



        // MOUVEMENTS
        if (!phase2)
        {
            if (surRail)
            {
                if (currentSeg == 6)
                    nextSeg = 1;

                else
                    nextSeg = currentSeg + 1;

                MouvementsJesus();
            }

            else if (launchAnimation && timerGeneral < 26.2)
            {
                transform.DOMoveY(0, 0.6f);
            }
        }

        else if (!dying)
        {
            timerPhase2 += Time.deltaTime;

            if(timerPhase2 > cooldownPhase2)
            {
                timerPhase2 = 0;

                int x = Random.Range(7, 9);
                int y = Random.Range(-4, 4);

                transform.DOMove(new Vector2(x, y), 0.5f);
            }
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
            if (timer2 > 3 || (timer2 > 1.75f && phase2))
            {
                Attaque2();
                timer2 = 0;
            }

            timer3 += Time.deltaTime;
            if (timer3 > 7 || (timer3 > cooldownPhase2 && phase2))
            {
                Attaque3();
                timer3 = 0;
            }
        }


        // DEGATS
        if (currentHealth <= 0 && !dying)
        {
            dying = true;

            transform.DOMove(new Vector2(9, 0), 1);
            transform.DOShakePosition(5, 1);

            cantAttack = true;

            MainManager.Instance.partie++;
            MainManager.Instance.SelectionDialogue();
        }
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

        rb.velocity = rail.LinearPosition(currentSeg, nextSeg, transition).normalized * JesusSpeed;
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

            gameObject.transform.DOShakePosition(0.04f, 0.05f);

            Destroy(collision.gameObject);
        }
    }

}
