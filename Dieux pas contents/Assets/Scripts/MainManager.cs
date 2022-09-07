using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Intro intro;
    public Dialogue1 dialogue1;
    public Dialogue2 dialogue2;
    public Dialogue3 dialogue3;
    public Dialogue4 dialogue4;

    public int numeroScript;
    public int partie;

    public bool noControl;
    public bool transitionPerso;

    public float timer;
    private bool stop;
    private string activeMiniGame;


    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
            Instance = this;

        else
            Destroy(gameObject);

        numeroScript = 0;
        partie = 1;
        timer = 0;
    }


    private void Start()
    {
        ReferencesUI.Instance.fondu.DOFade(1, 0);

        OuvertureScene(4);
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

        if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.A))
        {
            partie = 1;
            numeroScript = 1;

            SelectionDialogue();
        }

        if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.Z))
        {
            partie = 1;
            numeroScript = 2;

            SelectionDialogue();
        }

        if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.E))
        {
            FermetureScene(3);

            partie += 1;

            transitionPerso = true;

            numeroScript = 2;

            SelectionDialogue();
        }

        if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.R))
        {
            partie = 1;
            numeroScript = 4;

            SelectionDialogue();
        }


        // TRANSITION ENTREE DANS SCENE DE MINI JEU
        if (partie == 2 && SceneManager.GetActiveScene().name != activeMiniGame)
        {
            timer += Time.deltaTime;

            if(timer > 2.2f)
            {
                SceneManager.LoadScene(activeMiniGame);
                OuvertureScene(2);

                RefBackgrounds.Instance.resto.SetActive(false);
                RefBackgrounds.Instance.valhalla.SetActive(false);
                RefBackgrounds.Instance.ilePaques.SetActive(false);
                RefBackgrounds.Instance.ciel.SetActive(false);

                RefChara.Instance.gameObject.SetActive(false);
                ReferencesUI.Instance.dialogue.gameObject.SetActive(false);
                ReferencesUI.Instance.nom.gameObject.SetActive(false);
                ReferencesUI.Instance.fonds.SetActive(false);

                timer = 0;

                noControl = true;
            }
        }


        // TRANSITION SORTIE DU MINI JEU
        else if((partie == 3 || partie == 4) && noControl)
        {
            timer += Time.deltaTime;

            if (timer > 2.2f)
            {
                if(SceneManager.GetActiveScene().name != "Main")
                {
                    SceneManager.LoadScene("Main");
                    OuvertureScene(2);

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
                    stop = false;
                }
            }
        }


        // TRANSITION CHANGEMENT DE PERSONNAGE
        else if(transitionPerso)
        {
            noControl = true;
            timer += Time.deltaTime;

            if(timer > 3.2f)
            {
                if (!stop)
                {
                    OuvertureScene(3);

                    stop = true;
                    partie = 1;
                    numeroScript += 1;

                    SelectionDialogue();
                }

                else if(timer > 4f)
                {
                    stop = false;
                    noControl = false;
                    transitionPerso = false;
                    timer = 0;
                }
            }
        }
    }


    public void SelectionDialogue()
    {
        // INTRO
        if (numeroScript == 0)
        {
            if (partie == 1)
            {
                intro.AvancerDialogue1();
            }
        }

        // ZEUS
        else if (numeroScript == 1)
        {
            activeMiniGame = "Oscar";
            

            if (partie == 1)
            {
                dialogue1.AvancerDialogue1();
            }

            else if(partie == 2)
            {
                FermetureScene(2);
                noControl = true;
            } 

            else if(partie == 3)
            {
                FermetureScene(2);
                noControl = true;
            }

            else
            {
                dialogue1.AvancerDialogue2();
            }
        }


        // MAKE MAKE
        else if (numeroScript == 2)
        {
            activeMiniGame = "Make-Make";

            if (partie == 1)
            {
                dialogue2.AvancerDialogue1();
            }

            else if (partie == 2)
            {
                FermetureScene(2);
                noControl = true;
            }

            else if (partie == 3)
            {
                FermetureScene(2);
            }

            else
            {
                dialogue2.AvancerDialogue2();
            }
        }

        else if(numeroScript == 3)
        {
            activeMiniGame = "Odin";

            if (partie == 1)
            {
                dialogue3.AvancerDialogue1();
            }

            else if (partie == 2)
            {
                FermetureScene(2);
                noControl = true;
            }

            else if (partie == 3)
            {
                FermetureScene(2);
            }

            else
            {
                dialogue3.AvancerDialogue2();
            }
        }

        else if (numeroScript == 4)
        {
            activeMiniGame = "DARK JESUS";

            if (partie == 1)
            {
                dialogue4.AvancerDialogue1();
            }

            else if (partie == 2)
            {
                FermetureScene(2);
                noControl = true;
            }

            else if (partie == 3)
            {
                FermetureScene(2);
            }

            else
            {
                dialogue4.AvancerDialogue2();
            }
        }
    }

    public void OuvertureScene(float duree)
    {
        ReferencesUI.Instance.fondu.DOFade(0, duree);
    }


    public void FermetureScene(float duree)
    {
        ReferencesUI.Instance.fondu.DOFade(1, duree);
    }

    public void LoadScene(string nomScene)
    {
        SceneManager.LoadScene(nomScene);
    }
}
