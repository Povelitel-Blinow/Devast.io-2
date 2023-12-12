using Unity.Netcode;
using UnityEngine;

public class World : NetworkBehaviour
{
    [SerializeField] private Grid _grid;

    public override void OnNetworkSpawn()
    {
        if (IsHost == false) return;
        
        _grid.Init();
    }
}
