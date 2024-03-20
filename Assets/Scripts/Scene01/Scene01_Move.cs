using UnityEngine;

public class Scene01_Move : MonoBehaviour
{
    private float capsuleVelocity = 10f;
    void Update()
    {
        Move();
    }

    private void Move()       ///finalizado escena 1 con flechas de direccion !!!!!!!
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        float moveInputVertical = Input.GetAxisRaw("Vertical");

        // Obtenemos la posicion actual de la capsule
        Vector2 playerPosition = transform.position;

        // Calculamos la posicion nueva de la capsule para el eje x;
        playerPosition.x = this.transform.position.x + (moveInput * Time.deltaTime * this.capsuleVelocity);
        playerPosition.y = this.transform.position.y + (moveInputVertical * Time.deltaTime * this.capsuleVelocity);

        transform.position = playerPosition;
    }
}
