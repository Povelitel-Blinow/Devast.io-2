using Unity.Netcode;
using UnityEngine;

public class World : NetworkBehaviour
{
    [SerializeField] private Grid _grid;

    public static World Instance { get; private set; }

    public override void OnNetworkSpawn()
    {
        if(Instance == null)
        {
            Instance = this;
            _grid.Init();
            return;
        }
        Destroy(gameObject);
    }

    public GroundCell GetCellByPos(float x, float y)
    {
        return _grid.GetCellByPos(x, y);
    }
}
