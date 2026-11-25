using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events; 



public class Interactable : MonoBehaviour //gjord av edward
{
    public List<string> interactDialogue;

    public static Action<List<string>> OnInteract; 
  

    public void Interact()
    {
        OnInteract.Invoke(interactDialogue);
        Debug.Log("player interact");    
    } 
}
