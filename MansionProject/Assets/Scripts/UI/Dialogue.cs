using NUnit.Framework;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public static Dialogue instance { get; private set; }

    [Header("Dialogue settings")]  
    private List<string> dialogueList;
    private int currentIndex = 0;


    public static Action OnDialogueStart;
    public static Action OnDialogueEnd;

    [SerializeField] private TextMeshProUGUI TextBox;
    private void Start()
    {
        Interactable.OnInteract += StartDialogue;
        gameObject.SetActive(false);
    }



    public void StartDialogue(List<string> dialogue)
    {
 
        gameObject.SetActive(true);
        OnDialogueStart.Invoke();
        dialogueList = dialogue;
        TextBox.text = dialogueList[currentIndex]; 
    }

    private void NextDialogue()
    { 
        if (currentIndex < dialogueList.Count -1)
        {
            currentIndex++;
            TextBox.text = dialogueList[currentIndex];
        } 
        else
        {
            currentIndex = 0;  
            OnDialogueEnd.Invoke();
            gameObject.SetActive(false);
        }
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) ||  Input.GetKeyDown(KeyCode.Mouse0))
        {
            NextDialogue();
        }
    }
}
