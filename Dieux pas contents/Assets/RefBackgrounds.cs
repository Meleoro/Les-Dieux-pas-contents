using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefBackgrounds : MonoBehaviour
{
    public static RefBackgrounds Instance;

    public GameObject ciel;
    public GameObject cielDark;

    public GameObject resto;
    public GameObject restoFlou;

    public GameObject valhalla;
    public GameObject valhallaFlou;

    public GameObject ilePaques;

    public GameObject champs;

    public Image final;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        else
            Destroy(this);
    }
}
