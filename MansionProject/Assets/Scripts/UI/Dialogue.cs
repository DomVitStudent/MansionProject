using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public static Dialogue instance { get; private set; }

    [Header("Dialogue settings")]  
    private List<string> dialogueList;
    private int currentIndex = 0;


    public static Action OnDialogueStart;
    public static Action OnDialogueEnd;


    [Header("Typewriter effect")]
    private float writerSpeed;

    [SerializeField] private TextMeshProUGUI TextBox;
    private void Start()
    {
        Interactable.OnStart += StartDialogue;
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
    IEnumerator TypeWritterEffect(string Dialogue)
    { 
        TextBox.text = Dialogue; 
        TextBox.maxVisibleCharacters = 0;
        int visibleCharacters = 0; 

        for (int i = 0; i < dialogueList.Count; i++ )
        { 

            yield return new WaitForSeconds(writerSpeed);
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
