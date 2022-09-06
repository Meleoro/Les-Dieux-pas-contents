using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class BreakEggs : MonoBehaviour
{
    [SerializeField] private CircleCollider2D collider2D;
    [SerializeField] private GameObject haut;
    [SerializeField] private GameObject bas;
    [SerializeField] private GameObject jaune;
    [SerializeField] private Rigidbody2D hautRb;
    [SerializeField] private Rigidbody2D basRb;
    [SerializeField] private Rigidbody2D jauneRb;
    [SerializeField] private Rigidbody2D eggRb;
    public OeufManager oeufManager;
    private Vector3 dir;
    private Vector3 normDir;

    [SerializeField] private Vector3 morceauxPos;
    [SerializeField] private float breakPoint = 100;


    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EggLaunch());
        oeufManager = GameObject.Find("PANIER").GetComponent<OeufManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground") && eggRb.velocity.magnitude > breakPoint)
        {
            dir = col.gameObject.transform.position - gameObject.transform.position;
            normDir = dir.normalized;
            haut.SetActive(true);
            InheritVelocity(hautRb);
            bas.SetActive(true);
            InheritVelocity(basRb);
            jaune.SetActive(true);
            InheritVelocity(jauneRb);
            gameObject.SetActive(false);
            oeufManager.EggRespawn();
            oeufManager.score++;
        }
    }

    void InheritVelocity(Rigidbody2D morceauxDoeuf)
    {

        morceauxDoeuf.AddForce(normDir * eggRb.velocity * speed * -1, ForceMode2D.Impulse);
    }

    public IEnumerator EggLaunch()
    {
        eggRb.AddForce(Vector2.up * (15), ForceMode2D.Impulse);
        eggRb.angularVelocity = Random.Range(-500, 501);
        yield return new WaitForSeconds(0.5f);
        collider2D.enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;

    }
}


