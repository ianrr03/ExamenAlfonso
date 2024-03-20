using UnityEngine;

public class Scene03_CheckPoint : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer checkPointSpriteRenderer; //para acceder al spriterenderer y poder flipear el personaje al ir para atras
    public Color colorOriginal = Color.white; //color original spriteRenderer player
    public Color colorAzul = Color.blue; //color dañado spriteRenderer player


    //public GameObject ObjectToFind;
    //string objectName = "Has chocado con el checkPoint()";
    void Start()
    {
        //ObjectToFind = GameObject.Find(objectName);
        //Debug.Log(ObjectToFind.name);
    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) //funciona el trigger de chocar y cambiar el color (falta indicar con cual checkPoint ha chocado)
    {

        if (collision.gameObject.CompareTag("Player")) // si algo con la etiqueta de player lo toca
        {
            Debug.Log("Has chocado con un checkPoint");
            checkPointSpriteRenderer.color = colorAzul;
        }
    }

    
}

