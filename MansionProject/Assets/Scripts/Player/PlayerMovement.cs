
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class TopDownMovement : MonoBehaviour // modifierad skript av https://www.youtube.com/watch?v=HCaSnZvs90g
{
    [SerializeField] private float playerSpeed;
    private Vector2 playerInput;
    private bool movingEnabled = true;
    private Rigidbody2D rb;
  

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Dialogue.OnDialogueStart += disableMovement; 
        Dialogue.OnDialogueEnd += enableMovement;
    }
    private void Update()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");

        playerInput.Normalize();
    }
    private void FixedUpdate()
    { 
        if (movingEnabled)
        {
            rb.linearVelocity = playerInput * playerSpeed * Time.deltaTime;
        }
      
    }
    public void disableMovement()
    {
        movingEnabled = false; 
        rb.linearVelocity = Vector2.zero;
    }
        
      
    public void enableMovement() => movingEnabled = true;

}
