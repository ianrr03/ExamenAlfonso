using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Scene05_SceneManager : MonoBehaviour
{
    public List<GameObject> SpheresGreensInScene; //Hacemos una lista de esferas
    public List<GameObject> SquaresOrangesInScene; //Hacemos una lista de cuadrados
    
    private void Awake() //funciona el conteo de esferas verdes y naranjas
    {
        SpheresGreensInScene = GameObject.FindGameObjectsWithTag("SpheresGreens").ToList(); //añado las esferas en una lista y que me encuentre los objetos con un tag de spheres
        SquaresOrangesInScene = GameObject.FindGameObjectsWithTag("SpheresOranges").ToList(); //

        Debug.Log($"Hay {SpheresGreensInScene.Count} esferas verdes en tu escena "); // con count me cuenta los elementos que hay en esa lista
        Debug.Log($"Hay {SquaresOrangesInScene.Count} esferas naranjas en tu escena ");
        
    }
}
