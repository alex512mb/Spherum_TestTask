using UnityEngine;

public class CubesManager : MonoBehaviour
{
    private static CubesManager i;

    public static float DistanceBetweenCubes => i.distanceBetweenCubes; 
    
    [SerializeField]
    private Transform fisrtCube;
    [SerializeField]
    private Transform secondCube;

    private float distanceBetweenCubes;

    private void Awake()
    {
        i = this;
        CalculateDistance();
    }

    private void Update()
    {
        CalculateDistance();
    }

    private void CalculateDistance()
    {
        distanceBetweenCubes = Vector3.Distance(fisrtCube.position, secondCube.position);
    }
}
