using UnityEngine;

public class UvPicker : MonoBehaviour
{
    [Tooltip("Индекс текстуры в текстурном атласе")]
    public int indexSubTexture = 0;
    [Tooltip("Сколько есть текстур в текстурном")]
    public int countSubTextures = 20;
    [Tooltip("Количиство строк в текстурном атласе")]
    public int countRows = 8;
    [Tooltip("Количиство колонок в текстурном атласе")]
    public int countColumns = 8;
    
    private Material mat;
    private float texOffsetStepX;
    private float texOffsetStepY;
    

    private void Awake()
    {
        //находим материал нашего обьекта
        mat = GetComponent<Renderer>().material;
        
        //расчитываем размер текстурной координаты
        texOffsetStepX = 1f / countColumns;
        texOffsetStepY = 1f / countRows;

        //устанавливаем размер текстурной координаты
        mat.mainTextureScale = new Vector2(texOffsetStepX,texOffsetStepY);
    }

    private void Start()
    {
        UpdateUV();
    }


    private void Update()
    {
        //убери комент если хочешь потестировать на лету
        //UpdateUV();
    }

    private Vector2 GetTextureCoordinates(int indexTexture)
    {
        int clumpedIndex = indexTexture;
        if (indexSubTexture >= countSubTextures)
        {
            clumpedIndex = indexSubTexture % countSubTextures;
        }

        int passedRows = clumpedIndex / countColumns; 
        int x = clumpedIndex % countColumns;
        int y = 1 + (passedRows % countRows);
        return new Vector2(x * texOffsetStepX, -(y* texOffsetStepY));
    }

    private void UpdateUV()
    {
        mat.mainTextureOffset = GetTextureCoordinates(indexSubTexture);
    }
}
