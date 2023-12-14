public class Cell
{
    private int _posX;
    private int _posY;

    public GroundCell CurrentBlock { get; private set; }

    public bool IsOccupied => CurrentBlock != null;
    public Cell(int x, int y)
    {
        _posX = x;
        _posY = y;
    }

    public void Occupy(GroundCell block)
    {
        CurrentBlock = block;
    }

    public void VoidCell()
    {
        CurrentBlock = null;
    }
}
