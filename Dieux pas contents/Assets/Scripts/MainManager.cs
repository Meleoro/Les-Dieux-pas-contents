using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Dialogue1 dialogue1;
    public Dialogue2 dialogue2;

    public int numeroScript;
    public int partie;

    public bool noControl;

    public float timer;


    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
            Instance = this;

        else
            Destroy(gameObject);

        numeroScript = 1;
        partie = 1;
    }


    private void Start()
    {
        ReferencesUI.Instance.fondu.DOFade(1, 0);

        OuvertureScene();
    }


    private void Update()
    {
        if (!noControl)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SelectionDialogue();
            }
        }

        if (Input.GetKeyDown(KeyCode.AltGr))
        {
            partie += 1;

            SelectionDialogue();
        }


        // ENTREE DANS SCENE DE MINI JEU
        if (partie == 2 && SceneManager.GetActiveScene().name != "Oscar")
        {
            timer += Time.deltaTime;

            if(timer > 2.2f)
            {
                SceneManager.LoadScene("Oscar");
                OuvertureScene();

                RefChara.Instance.gameObject.SetActive(false);
                ReferencesUI.Instance.dialogue.gameObject.SetActive(false);
                ReferencesUI.Instance.nom.gameObject.SetActive(false);
                ReferencesUI.Instance.fonds.SetActive(false);

                timer = 0;
            }
        }

        // SORTIE DU MINI JEU
        else if((partie == 3 || partie == 4) && noControl)
        {
            timer += Time.deltaTime;

            if (timer > 2.2f)
            {
                if(SceneManager.GetActiveScene().name != "Main")
                {
                    SceneManager.LoadScene("Main");
                    OuvertureScene();

                    partie += 1;
                    SelectionDialogue();
                }

                RefChara.Instance.gameObject.SetActive(true);
                ReferencesUI.Instance.dialogue.gameObject.SetActive(true);
                ReferencesUI.Instance.nom.gameObject.SetActive(true);
                ReferencesUI.Instance.fonds.SetActive(true);

                if (timer > 3.5f)
                {
                    noControl = false;
                    timer = 0;
                }
            }
        }
    }


    public void SelectionDialogue()
    {
        // ZEUS
        if (numeroScript == 1)
        {
            if(partie == 1)
            {
                dialogue1.AvancerDialogue1();
            }

            else if(partie == 2)
            {
                FermetureScene();
                noControl = true;
            } 

            else if(partie == 3)
            {
                FermetureScene();
            }

            else
            {
                dialogue1.AvancerDialogue2();
            }
        }


        // ODIN
        else if (numeroScript == 2)
        {
            if (partie == 1)
            {
                dialogue2.AvancerDialogue1();
            }

            else if (partie == 2)
            {
                FermetureScene();
                noControl = true;
            }

            else if (partie == 3)
            {
                FermetureScene();
            }

            else
            {
                dialogue2.AvancerDialogue2();
            }
        }
    }

    public void OuvertureScene()
    {
        ReferencesUI.Instance.fondu.DOFade(0, 2);
    }


    public void FermetureScene()
    {
        ReferencesUI.Instance.fondu.DOFade(1, 2);
    }
}
