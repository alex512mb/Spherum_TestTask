using TMPro;
using UnityEngine;

public class Distance_UI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textDistance;
    
    private void Update()
    {
        textDistance.text = CubesManager.DistanceBetweenCubes.ToString();
    }
}
