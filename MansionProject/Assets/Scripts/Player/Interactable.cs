using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events; 



public class Interactable : MonoBehaviour //gjord av edward
{
    private static KeyCode InteractKey = KeyCode.E;
    private bool playerInRange;

    public List<string> interactDialogue;
    public UnityEvent OnPlayerEnter; 
    public UnityEvent OnPlayerExit;
    public static Action<List<string>> OnInteract; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
            playerInRange = true;
            Debug.Log("player enter");
            OnPlayerEnter.Invoke(); 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("player leave");
            OnPlayerExit.Invoke();
        }
    } 
    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(InteractKey))
        {
            Interact();
        }
    }
    private void Interact()
    {
        OnInteract.Invoke(interactDialogue);
        Debug.Log("player interact");    
    }
}
