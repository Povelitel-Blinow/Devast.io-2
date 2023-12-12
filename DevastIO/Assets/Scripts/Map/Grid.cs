using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private Vector2Int _gridSize;

    [SerializeField] private Block _emptyBlock; //tmp

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
                Instantiate(_emptyBlock, transform).Init(x, y);
            }
        }
    }
    
}
