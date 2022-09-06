using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEggs : MonoBehaviour
{
    [SerializeField] private GameObject haut;
    [SerializeField] private GameObject bas;

    [SerializeField] private GameObject jaune;
    [SerializeField] private Rigidbody2D hautRb;
    [SerializeField] private Rigidbody2D basRb;
    [SerializeField] private Rigidbody2D jauneRb;
    [SerializeField] private Rigidbody2D eggRb;
    [SerializeField] private Vector3 oeufPos;

    [SerializeField] private Vector3 morceauxPos;
    [SerializeField] private float breakPoint = 100;

    public float speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground") && eggRb.velocity.magnitude > breakPoint)
        {
            haut.SetActive(true);
            InheritVelocity(hautRb);
            bas.SetActive(true);
            InheritVelocity(basRb);
            jaune.SetActive(true);
            InheritVelocity(jauneRb);
            gameObject.SetActive(false);
        }
    }

    void InheritVelocity(Rigidbody2D morceauxDoeuf)
    {
        morceauxDoeuf.velocity = eggRb.velocity * -1;
        Vector3 dir = morceauxPos - gameObject.transform.position;
        Vector3 normDir = dir.normalized;
        morceauxDoeuf.AddForce(normDir * eggRb.velocity * speed * -1, ForceMode2D.Impulse);
    }
}


