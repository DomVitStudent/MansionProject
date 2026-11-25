using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleBase : MonoBehaviour
{
   

    public UnityEvent OnPuzzleComplete;

  

    protected virtual void CompletePuzzle()
    {
        OnPuzzleComplete.Invoke();
    }
}
