using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class OeufManager : MonoBehaviour
{
    public GameObject oeufObject;

    [SerializeField] private Vector3 oeufRespawn;
    
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI texte;
    public Transform panier;
    
    public int score;
    [SerializeField] private int badScore;
    public GameOver loseCondition;
    private bool newScene;
    [SerializeField] private GameObject ange;
    public bool canSpawnEgg = false;
    public bool brokenEgg = false;
    
    public enum Panier
    {
        small,
        normal,
        big,
        XXL
    }

    private Panier size;
    // Start is called before the first frame update
    void Start()
    {
        RefBackgrounds.Instance.ilePaques.SetActive(false);

        MainManager.Instance = GameObject.Find("GameManager").GetComponent<MainManager>();
        ange = GameObject.Find("Ange");
        size = Panier.small;
        StartCoroutine(AngeDialogue(28));
        Ange.Instance.AngeApparait("Bon, ok je comprends que ca peut être déroutant d'être élu de la prophétie et sauver le monde. Les responsabilitées, le stress...",6,0,
            "Bref, oublions ce qui c'est passé avec Zeus et concentrons nous sur la nouvelle tâche à accomplir.",5,0,
            "La mission est simple, il faut mettre les oeufs dans le panier, pour se faire, il faut cliquer et maintenir enfoncé le bouton gauche de la souris, puis relâcher au dessus du panier.",7,0,
            "CEEEPEENDAAAAAANT!",2,1,
            "Manipulez les oeufs avec êxtreme attention, car les jeter trop fort au sol va certainement les casser. Bonne chance élu de la prophétie, je crois en vous!",6,0);
    }

    // Update is called once per frame
    void Update()
    {


        if (score == 1 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            EggRespawn();
            text.text = score + "/10";
        }
        else if (score == 2 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            EggRespawn();
            text.text = score + "/10";
        }
        else if (score == 3 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            text.text = score + "/10";
            StartCoroutine(AngeDialogue2(24));
            Ange.Instance.AngeApparait("Ah, attention élu de la prophétie! Les oeufs ne semblent pas atteindre leur objectif!",5,0.3f,
                "Prennez tout votre temps héros, n'oubliez pas que tant que vous ne relâchez pas le clic gauche de la souris, l'oeuf suivra toujours la souris.",7,0,
                "Efforcez-vous de ne pas faire de gestes brusques et relachez le clic gauche uniquement quand l'oeuf est bien au dessus du panier.",6,0,
                "Permettez moi d'élargir le panier pour vous faciliter la tâche!",3,0,
                "",0,0);
        }
        else if (score == 4 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            EggRespawn();
            text.text = score + "/10";
        }
        else if (score == 5 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            EggRespawn();
            text.text = score + "/10";
        }
        else if (score == 6 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            text.text = score + "/10";
            StartCoroutine(AngeDialogue3(11));
            Ange.Instance.AngeApparait("Euhm...",3,0,
                "Vous faut-il un panier encore plus grand?",4,0,
                "Très bien...",3,0,
                "",0,0,
                "",0,0);

        }
        else if (score == 7 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            EggRespawn();
            text.text = score + "/10";
        }
        else if (score == 8 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            EggRespawn();
            text.text = score + "/10";
        }
        else if (score == 9 && !canSpawnEgg && brokenEgg)
        {
            canSpawnEgg = true;
            brokenEgg = false;
            text.text = score + "/10";
            StartCoroutine(AngeDialogue4(16));
            Ange.Instance.AngeApparait("Mais...",3,0,
                "MAIS CESSEZ DONC!",3,0.8f,
                "ARRETEZ DE JOUER!",4,0.8f,
                "LES OEUFS DANS LE PANIER JE VOUS PRIE!",3,0f,
                "LE DESTIN DU MONDE ENTIER EN DEPEND!",3,2);
        }
        else if (score == 10 && !newScene)
        {
            newScene = true;
            text.text = score + "/10";
            MainManager.Instance.partie++;
            MainManager.Instance.SelectionDialogue();
            Debug.Log(MainManager.Instance.partie);
        }
        switch (size)
        {
            case Panier.normal:
                panier.localScale = Vector3.MoveTowards(panier.localScale,new Vector3(3, 2, 1),1*Time.deltaTime);
                panier.position = Vector3.MoveTowards(panier.position,new Vector3(panier.position.x, -2, 0),0.5f*Time.deltaTime);
                return;
            case Panier.big:
                panier.localScale = Vector3.MoveTowards(panier.localScale,new Vector3(5, 2, 1),1*Time.deltaTime);
                return;
            case Panier.XXL:
                panier.localScale = Vector3.MoveTowards(panier.localScale,new Vector3(11, 3, 1),1*Time.deltaTime);
                panier.position = Vector3.MoveTowards(panier.position,new Vector3(panier.position.x, -1, 0),0.2f*Time.deltaTime);
                return;
        }
        texte.text = badScore + "/3";
        if (badScore == 3 && !newScene)
        {
            newScene = true;
            GameOver.Instance.LoseGame();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ingredient"))
        {
            Destroy(col.gameObject);
            EggRespawn();
            badScore++;
        }
    }

    public void EggRespawn()
    {
        Instantiate(oeufObject, new Vector3(Random.Range(2f,9f),oeufRespawn.y,oeufRespawn.z), transform.rotation);
        canSpawnEgg = false;
    }

    public IEnumerator AngeDialogue(float time)
    {
        yield return new WaitForSeconds(time);
        EggRespawn();
        brokenEgg = false;
    }
    public IEnumerator AngeDialogue2(float time)
    {
        yield return new WaitForSeconds(19);
        size = Panier.normal;
        yield return new WaitForSeconds(time-19);
        EggRespawn();
        brokenEgg = false;
    }
    public IEnumerator AngeDialogue3(float time)
    {
        yield return new WaitForSeconds(7);
        size = Panier.big;
        yield return new WaitForSeconds(time-7);
        EggRespawn();
        brokenEgg = false;
    }
    public IEnumerator AngeDialogue4(float time)
    {
        yield return new WaitForSeconds(10);
        size = Panier.XXL;
        yield return new WaitForSeconds(time-10);
        EggRespawn();
        brokenEgg = false;
    }
}
