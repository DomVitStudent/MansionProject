using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    [SerializeField] private float charactersPerSecond = 20f;
    private Coroutine _typingCoroutine;

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
        ShowText(dialogueList[currentIndex]);
    }

    private void NextDialogue()
    { 
        if (currentIndex < dialogueList.Count -1)
        {
            currentIndex++;
            ShowText(dialogueList[currentIndex]); 
         
        } 
        else
        {
            currentIndex = 0;  
            OnDialogueEnd.Invoke();
            gameObject.SetActive(false);
        }
       
    }
    public void InteractDialogue(string Text )
    {
        List<string> dialouge = Text.Split(" : ").ToList(); //denna är lite buggad men låter ha flera lines för interact
        StartDialogue(dialouge);
    }
    private void ShowText(string text) //typewriter effect: https://blog.febucci.com/2026/05/how-to-make-a-typewriter-effect-in-unity-with-textmeshpro/
    { 
        // Stop any existing typing before starting a new one
        if (_typingCoroutine != null)
            StopCoroutine(_typingCoroutine);

        // set the entire text once, but make it hidden
        TextBox.text = text;
        TextBox.maxVisibleCharacters = 0;

        // Force TMP to parse the text and compute character count
        TextBox.ForceMeshUpdate(); // might not be necessary in all cases

        _typingCoroutine = StartCoroutine(TypeText());
    }

    private IEnumerator TypeText()
    {
        int totalCharacters = TextBox.textInfo.characterCount;
        float delay = 1f / charactersPerSecond;

        for (int i = 0; i < totalCharacters; i++)
        {
            TextBox.maxVisibleCharacters = i + 1;
            yield return new WaitForSeconds(delay);
        }

        // Ensure everything is visible at the end
        TextBox.maxVisibleCharacters = totalCharacters;
        _typingCoroutine = null;
    }
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) ||  Input.GetKeyDown(KeyCode.Mouse0))
        {
            NextDialogue();
        }
    }
}
