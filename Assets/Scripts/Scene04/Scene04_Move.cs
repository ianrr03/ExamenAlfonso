using UnityEngine;

public class Scene04_Move : MonoBehaviour
{
    [SerializeField]
    private float velocityFactor;

    private bool isGrounded = false;

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

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        this.isGrounded = false;
    }
}
