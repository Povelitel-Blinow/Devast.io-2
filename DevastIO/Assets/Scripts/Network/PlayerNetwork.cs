using Unity.Netcode;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    [SerializeField] private Player _player;

    public override void OnNetworkSpawn()
    {
        if (IsOwner == false) return;

        _player.Init();
    }

    private void Update()
    {
        if (IsOwner == false) return;

        _player.UpdatePlayer();
    }
}
