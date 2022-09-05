using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReferencesUI : MonoBehaviour
{
    public static ReferencesUI Instance;

    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI nom;

    public Image fondu;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        MainManager.Instance.SelectionDialogue();
    }
}
