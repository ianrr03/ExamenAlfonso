using UnityEngine;

public class Scene04_Move : MonoBehaviour
{
    [SerializeField]
    private float velocityFactor;

    private bool isGrounded = false;

    float impulse = 11.0f;
    private Rigidbody2D rg2D;

    private void Start()
    {
        this.rg2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
        
    }

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        var actualVelocity = this.rg2D.velocity;
        var  newVelocity = new Vector2(moveX * this.velocityFactor, actualVelocity.y) ;
        this.rg2D.velocity = newVelocity;
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {

            rg2D.AddForce(transform.up * impulse, ForceMode2D.Impulse);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
    

                this.isGrounded = true;

            
    }
    private void OnCollisionExit2D(Collision2D collision) ///funciona el salto en el suelo
    {
        this.isGrounded = false;

    }
}
