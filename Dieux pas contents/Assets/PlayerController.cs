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
        panierPos = Input.mousePosition;
        panierPos.z = Camera.main.nearClipPlane + 9.7f;
        worldPos = Camera.main.ScreenToWorldPoint(panierPos);

        transform.position = worldPos;

        if (Input.GetKey(KeyCode.Mouse0) && timer < 0)
        {
            Attaque();
            timer = cooldownGun;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }


    void Attaque()
    {
        GameObject oui = Instantiate(bullet, bulletExit.transform.position + new Vector3(0, 0.1f, 0), Quaternion.Euler(0, 0, -90));
        GameObject non = Instantiate(bullet, bulletExit.transform.position + new Vector3(0, -0.1f, 0), Quaternion.Euler(0, 0, -90));

        Destroy(oui, 6f);
        Destroy(oui, 6f);
    }
}
