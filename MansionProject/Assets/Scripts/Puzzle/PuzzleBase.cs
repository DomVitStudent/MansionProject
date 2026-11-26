using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleBase : MonoBehaviour
{

    [SerializeField] private ItemBase rewardItem;
    public UnityEvent OnPuzzleComplete;

  

    protected virtual void CompletePuzzle()
    {
        OnPuzzleComplete.Invoke();
    }
}
