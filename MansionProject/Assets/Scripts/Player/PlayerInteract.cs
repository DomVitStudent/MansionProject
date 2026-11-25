using UnityEngine;
using UnityEngine.Events;

public class PlayerInteract : MonoBehaviour
{
    private static KeyCode InteractKey = KeyCode.E;

    private Interactable currentTarget;

    public UnityEvent OnPlayerEnter;
    public UnityEvent OnPlayerExit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        if (Input.GetKeyDown(InteractKey) && currentTarget != null)
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
    public void test()
    {
        Debug.Log("test");
    }
}
