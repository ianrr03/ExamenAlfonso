using UnityEngine;

public class Scene02_Move : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField]
    private float moveSpeed;


    private void Start() ///funciona escena 2
    {
        this.rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        MoveVertical();
    }

    private void Move()
    {
        var horizontalMove = Input.GetAxisRaw("Horizontal") * this.moveSpeed;

        var newVelocity = new Vector2(horizontalMove, rb2D.velocity.y);
        this.rb2D.velocity = newVelocity;
    }
    private void MoveVertical()
    {
        var verticalMove = Input.GetAxisRaw("Vertical") * this.moveSpeed;

        var newVelocity = new Vector2(rb2D.velocity.x, verticalMove);
        this.rb2D.velocity = newVelocity;
    }
}
