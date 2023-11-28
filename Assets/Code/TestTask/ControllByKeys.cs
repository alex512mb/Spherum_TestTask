using UnityEngine;

public class ControllByKeys : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    [SerializeField]
    private string horizontalAxis = "HorizontalWASD";
    [SerializeField]
    private string verticalAxis = "VerticalWASD";

    private void Update()
    {
        // берем значение осей
        float horizontal = Input.GetAxis(horizontalAxis);
        float vertical = Input.GetAxis(verticalAxis);
        
        //рассчиваем вектор движения
        Vector3 moveVector = new Vector3(horizontal, 0.0f, vertical) * moveSpeed * Time.deltaTime;
        
        //выполняем движение
        transform.Translate(moveVector);
    }
}
