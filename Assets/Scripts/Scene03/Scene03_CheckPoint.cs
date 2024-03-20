using UnityEngine;

public class Scene03_CheckPoint : MonoBehaviour
{

    void Start()
    {
    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) //funciona el trigger de chocar, falta indicar con cual choca y cambiar el color 
    {
        if (collision.gameObject.CompareTag("Player")) // si algo con la etiqueta de player lo toca
        {
            Debug.Log("Has chocado con un checkPoint");

        }
    }

    private IEnumerator CambiarColorCheckPoint() //funciona siuuuuuuuuu
    {
        playerSpriteRenderer.color = colorRojo;
        yield return new WaitForSeconds(tiempoEsperaPlayerVolverColorOriginal);
        // Volver al color original
        playerSpriteRenderer.color = colorOriginal;
    }
}

