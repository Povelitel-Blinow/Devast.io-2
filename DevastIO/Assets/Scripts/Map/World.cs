using Unity.Netcode;
using UnityEngine;

public class World : NetworkBehaviour
{
    [SerializeField] private Grid _grid;

    public static World Instance { get; private set; }

    public override void OnNetworkSpawn()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);


        if (IsHost == false) return;
        _grid.Init();
    }

    public GroundCell GetCellByPos(float x, float y)
    {
        return _grid.GetCellByGround(x, y);
    }
}
