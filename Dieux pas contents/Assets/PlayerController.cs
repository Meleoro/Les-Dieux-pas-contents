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


    [Header("Ghost Effect")]
    public float ghostCooldown;
    public GameObject ghost;
    private float timerGhost;


    void Start()
    {
        panierPos = Input.mousePosition;
        panierPos.z = Camera.main.nearClipPlane + 9.7f;
        worldPos = Camera.main.ScreenToWorldPoint(panierPos);

        offset = transform.position - worldPos;

        Ange.Instance.AngeApparait("Oui", 2, 0.2f, 
            "Non", 1, 0.2f,
            "Oui", 2, 0.2f,
            "Non", 1, 0,
            "AHAH", 3, 0);
    }

    
    void Update()
    {
        // POSITION
        panierPos = Input.mousePosition;
        panierPos.z = Camera.main.nearClipPlane + 9.7f;
        worldPos = Camera.main.ScreenToWorldPoint(panierPos);

        transform.position = worldPos;


        // GHOST EFFECT
        timerGhost += Time.deltaTime;

        if(timerGhost > ghostCooldown)
        {
            timerGhost = 0;

            GameObject clone = Instantiate(ghost, worldPos, Quaternion.identity);
            Destroy(clone, 1f);
        }


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
        if (currentHealth < 0 && !isDead)
        {
            isDead = true;

            GameOver.Instance.LoseGame();
        }
    }


    void Attaque()
    {
        GameObject oui = Instantiate(bullet, bulletExit.transform.position + new Vector3(0, 0.1f, 0), Quaternion.Euler(0, 0, -90));
        GameObject non = Instantiate(bullet, bulletExit.transform.position + new Vector3(0, -0.1f, 0), Quaternion.Euler(0, 0, -90));

        Destroy(oui, 3f);
        Destroy(non, 3f);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "JesusShot" && !isHit)
        {
            RefCamera.Instance.CameraShake(0.6f, 0.4f);

            currentHealth -= 1;
            isHit = true;
        }
    }
}
