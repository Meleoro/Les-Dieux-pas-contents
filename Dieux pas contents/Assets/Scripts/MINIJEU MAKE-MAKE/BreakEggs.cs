using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEggs : MonoBehaviour
{
    [SerializeField] private GameObject haut;
    [SerializeField] private GameObject bas;

    [SerializeField] private GameObject jaune;

    [SerializeField] private Vector3 oeufPos;

    [SerializeField] private Vector3 morceauxPos;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        haut = GameObject.Find("Coquille haute");
        bas = GameObject.Find("Coquille basse");
        jaune = GameObject.Find("Jaune d'oeuf");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            haut.SetActive(true);
            InheritVelocity(haut.GetComponent<Rigidbody2D>());
            bas.SetActive(true);
            InheritVelocity(bas.GetComponent<Rigidbody2D>());
            jaune.SetActive(true);
            InheritVelocity(jaune.GetComponent<Rigidbody2D>());
            gameObject.SetActive(false);
        }
    }

    void InheritVelocity(Rigidbody2D morceauxDoeuf)
    {
        Vector3 dir = morceauxPos - oeufPos;
        Vector3 normDir = dir.normalized;
        morceauxDoeuf.AddForce(normDir * gameObject.GetComponent<Rigidbody2D>().velocity * -1);
    }
}


