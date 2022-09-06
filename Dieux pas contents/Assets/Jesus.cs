using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jesus : MonoBehaviour
{
    public Rail rail;

    private int currentSeg;
    private float transition;
    private bool isCOmpleted;

    private int nextSeg;

    public float JesusSpeed;

    [Header("Attaques")]
    public GameObject bullet;
    public GameObject bulletSpawner;
    private float timer;




    private void Start()
    {
        currentSeg = 1;
    }


    private void Update()
    {
        if (currentSeg == 6)
            nextSeg = 1;

        else
            nextSeg = currentSeg + 1;

        MouvementsJesus();



        // ATTAQUES
        Attaque1();

        timer += Time.deltaTime;

        if(timer > 3)
        {
            Attaque2();
            timer = 0;
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

        transform.position = rail.LinearPosition(currentSeg, nextSeg, transition);
    }


    void Attaque1()
    {
        for (int i = 0; i < 20; i++)
        {
            float modif = Random.Range(-2, 2);
            GameObject oui = Instantiate(bullet, transform.position, Quaternion.EulerAngles(0, 0, 90 + modif));

            Destroy(oui, 5f);
        }
    }

    void Attaque2()
    {
        for (int i = 0; i < 10; i++)
        {
            float modif = Random.Range(-2, 2);
            GameObject oui = Instantiate(bullet, transform.position, Quaternion.Euler(0, 0, 90 + modif));

            Destroy(oui, 5f);
        }
    }
}
