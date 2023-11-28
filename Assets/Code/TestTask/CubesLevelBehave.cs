using UnityEngine;
using UnityEngine.SceneManagement;

public class CubesLevelBehave : MonoBehaviour
{
    [SerializeField]
    private GameObject spheresRoot;

    private void Update()
    {
        float distanceBetweenCubes = CubesManager.DistanceBetweenCubes;

        if (distanceBetweenCubes < 1)
        {
            //переходим на уровен 2 так как расстояние между кубами меньше 1
            SceneManager.LoadScene("Level_2");
        }
        else if (distanceBetweenCubes >= 2)
        {
            //скрываем сферы так как расстояние между кубами больше двух
            spheresRoot.SetActive(false);
        }
        else
        {
            //показываем сферы так как расстояние между кубами меньше двух и больше еденицы
            spheresRoot.SetActive(true);
        }
    }
    
}
