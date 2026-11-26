using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract : MonoBehaviour
{
    private static KeyCode InteractKey = KeyCode.E;
    [SerializeField] private int interactLocks = 0;

    private Interactable currentTarget;

    public UnityEvent OnPlayerEnter;
    public UnityEvent OnPlayerExit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    private void Start()
    {
        Dialogue.OnDialogueStart += DisableInteraction;
        Dialogue.OnDialogueEnd += EnableInteraction;
        PanelView.OnPanelOpen += DisableInteraction;
        PanelView.OnPanelClose += EnableInteraction;
    }
    private void Update()
    {
        if (Input.GetKeyDown(InteractKey) && currentTarget != null && interactLocks == 0)
        {
            currentTarget.Interact();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.GetComponent<Interactable>() != null)
        {
            Debug.Log("enter");
            OnPlayerEnter.Invoke();
            currentTarget = collision.GetComponent<Interactable>();
        }
        
      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (currentTarget != null)
        {
            Debug.Log("Leave");
            currentTarget = null;
            OnPlayerExit.Invoke();
          
        }
    }
    public void DisableInteraction()
    {
        interactLocks++;
    }


    public void EnableInteraction() => interactLocks--;
}
