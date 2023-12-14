using UnityEngine;

public class PlayerBuild : MonoBehaviour
{
    //tmp
    [SerializeField] private Block _block;

    public void Build()
    {
        Debug.Log(World.Instance == null);
        GroundCell groundCell = World.Instance.GetCellByPos(transform.position.x, transform.position.y);

        if (groundCell == null) return;
        groundCell.TryOccupy(_block);
    }
}
