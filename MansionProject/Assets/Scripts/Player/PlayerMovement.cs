
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour // modifierad skript av https://www.youtube.com/watch?v=HCaSnZvs90g
{
    [SerializeField] private float playerSpeed;
    private Vector2 playerInput;
    [SerializeField] private int movementLocks = 0;
    private Rigidbody2D rb;
  

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Dialogue.OnDialogueStart += disableMovement; 
        Dialogue.OnDialogueEnd += enableMovement;
        PanelView.OnPanelOpen += disableMovement; 
        PanelView.OnPanelClose += enableMovement;
    }
    private void Update()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");

        playerInput.Normalize();
    }
    private void FixedUpdate()
    { 
        if (movementLocks == 0)
        {
            rb.linearVelocity = playerInput * playerSpeed * Time.deltaTime;
        }
      
    }
    public void disableMovement()
    {
        movementLocks ++; 
        rb.linearVelocity = Vector2.zero;
    }
        
      
    public void enableMovement() => movementLocks --;

}
