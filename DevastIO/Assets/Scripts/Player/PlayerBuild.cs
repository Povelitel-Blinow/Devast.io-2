using Unity.Netcode;
using UnityEngine;

public class PlayerBuild : NetworkBehaviour
{
    //tmp
    [SerializeField] private Block _block;

    [ServerRpc]
    public void BuildServerRpc()
    {
        GroundCell groundCell = World.Instance.GetCellByPos(transform.position.x, transform.position.y);

        Build(groundCell);
    }

    private void Build(GroundCell groundCell)
    {
        if (groundCell == null) return;
        groundCell.TryOccupy(_block);
    }
}
