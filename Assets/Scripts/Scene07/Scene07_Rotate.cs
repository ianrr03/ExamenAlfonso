using UnityEngine;

public class Scene07_Rotate : MonoBehaviour
{
    [SerializeField]
    private GameObject rotationPivot;

    [SerializeField]
    private float angleFactor;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float bulletForce;

    private void Update()
    {
        Rotate();
        Fire();
    }

    private void Rotate()
    {
        
    }

    private void Fire()
    {
        
    }
}
