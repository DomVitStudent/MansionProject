
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class TopDownMovement : MonoBehaviour // modifierad skript av https://www.youtube.com/watch?v=HCaSnZvs90g
{
    private float playerSpeed;
    private Vector2 playerInput;
    private Rigidbody2D rb;
  

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");

        playerInput.Normalize();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = playerInput * playerSpeed * Time.deltaTime;
    }
}
