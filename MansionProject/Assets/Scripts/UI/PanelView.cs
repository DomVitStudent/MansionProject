using System;
using UnityEngine;

public class PanelView : MonoBehaviour
{
    public static Action OnPanelOpen;
    public static Action OnPanelClose;
    private void OnEnable()
    {
  
        OnPanelOpen.Invoke();
    }
    private void OnDisable()
    {
        OnPanelClose.Invoke();
    }
}
