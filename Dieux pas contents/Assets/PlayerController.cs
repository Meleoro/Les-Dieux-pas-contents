using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 offset;

    private Vector3 panierPos;
    private Vector3 worldPos;

    public GameObject bullet;
    public GameObject bulletExit;

    private float timer;
    public float cooldownGun;

    public int health;
    public int currentHealth;
    public bool isDead;
    public float cooldownHit;
    private float timerHit;
    private bool isHit;


    void Start()
    {
        panierPos = Input.mousePosition;
        panierPos.z = Camera.main.nearClipPlane + 9.7f;
        worldPos = Camera.main.ScreenToWorldPoint(panierPos);

        offset = transform.position - worldPos;

        Ange.Instance.AngeApparait("Oui", 2, "Non", 1, "Oui", 2, "Non", 1, "AHAH", 3);
    }

    
    void Update()
    {
        // POSITION
        panierPos = Input.mousePosition;
        panierPos.z = Camera.main.nearClipPlane + 9.7f;
        worldPos = Camera.main.ScreenToWorldPoint(panierPos);

        transform.position = worldPos;


        // ATTAQUE
        if (Input.GetKey(KeyCode.Mouse0) && timer < 0)
        {
            Attaque();
            timer = cooldownGun;
        }
        else
        {
            timer -= Time.deltaTime;
        }


        // INVINCIBILITE
        if (isHit)
        {
            timerHit += Time.deltaTime;

            if(timerHit > cooldownHit)
            {
                timerHit = 0;
                isHit = false;
            }
        }


        // MORT
        if (currentHealth < 0)
        {
            isDead = true;
        }
    }


    void Attaque()
    {
        GameObject oui = Instantiate(bullet, bulletExit.transform.position + new Vector3(0, 0.1f, 0), Quaternion.Euler(0, 0, -90));
        GameObject non = Instantiate(bullet, bulletExit.transform.position + new Vector3(0, -0.1f, 0), Quaternion.Euler(0, 0, -90));

        Destroy(oui, 4f);
        Destroy(oui, 4f);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "JesusShot" && !isHit)
        {
            RefCamera.Instance.CameraShake(0.50f, 0.3f);

            currentHealth -= 1;
            isHit = true;
        }
    }
}
