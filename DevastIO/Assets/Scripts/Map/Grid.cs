using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private Vector2Int _gridSize;

    [SerializeField] private GroundCell _emptyBlock; //tmp

    private const int GridBorderOffset = 1;

    public Cell[,] Cells { get; private set; }
    public int Size => _gridSize.y;

    public void Init()
    {
        Cells = new Cell[_gridSize.x, _gridSize.y];

        for (int x = 0; x < _gridSize.x; x++)
        {
            for (int y = 0; y < _gridSize.y; y++)
            {
                Cells[x, y] = new Cell(x, y);
                GroundCell groundCell = Instantiate(_emptyBlock, transform);
                groundCell.Init(x, y);
                Cells[x, y].Occupy(groundCell);
            }
        }
    }

    public GroundCell GetCellByPos(float x, float y)
    {
        int newX = Mathf.FloorToInt(x / GridBorderOffset);
        int newY = Mathf.FloorToInt(y / GridBorderOffset);  

        if ((newX >= _gridSize.x || newX < 0) || (newY >= _gridSize.y || newY < 0))
        {
            return null;
        }

        return Cells[newX, newY].CurrentBlock;
    }
    
}
