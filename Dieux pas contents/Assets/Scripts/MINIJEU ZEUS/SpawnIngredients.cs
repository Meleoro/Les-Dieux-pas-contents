using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnIngredients : MonoBehaviour
{
    public float spawnHeight = 6;

    public float spawnX;

    public float spawnDelay;

    private bool newScene = false;

    [SerializeField] private float maxDelay = 10;

    [SerializeField] private float baseDelay = 1;

    [SerializeField] private Rigidbody2D ingredient;
    public int score;
    public int badScore;
    public GameOver loseCondition;

    [SerializeField] private float startDelay;
    [SerializeField] private bool ange2 = false;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI texte;

    private bool canDelay;
    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance = GameObject.Find("GameManager").GetComponent<MainManager>();
        loseCondition = GameObject.Find("MiniManager").GetComponent<GameOver>();
        startDelay = baseDelay;
        score = 0;
        canDelay = false;
        StartCoroutine(StartAnge());
        Ange.Instance.AngeApparait("OK nous y voila", 3, "Pour ta première mission comme Zeus te l'a dit est de préparer à manger", 4, "Pour cela rien de plus simple il suffit de récuperer les bons ingrédients dans la casserole",8,"Pour bouger la casserole il te faut simplement bouger la souris de gauche à droite de facon à ce que la casserole soit sous des pates' un steak ou bien une tomate.",6,"Mais SURTOUT PAS un sac poubelle ou une arrete de poisson. Sur ceux bonne chance élu de la prophétie!", 6);
        
    }

    // Update is called once per frame
    void Update()
    {
        texte.text = badScore + "/10";
        text.text = score + "/5";
        if (baseDelay >= 0 && canDelay)
        {
            baseDelay -= Time.deltaTime;
        }
        else if(canDelay)
        {
            baseDelay = startDelay;
            spawnX = Random.Range(-10, 11);
            spawnDelay = Random.Range(0, maxDelay) + baseDelay;
            Instantiate(ingredient, new Vector3(spawnX,spawnHeight,0), gameObject.transform.rotation);
        }

        if (badScore == 10)
        {
            loseCondition.Lost = true;
        }

        if (score == 2 && !ange2)
        {
            ange2 = true;
            
        }


        if (score == 5 && !newScene)
        {
            newScene = true;
            MainManager.Instance.partie = 3;
            MainManager.Instance.SelectionDialogue();
            Debug.Log(MainManager.Instance.partie);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ingredient"))
        {
            Destroy(other.gameObject);
        }
    }

    private IEnumerator StartAnge()
    {
        yield return new WaitForSeconds(27);
        canDelay = true;
    }
    
}
