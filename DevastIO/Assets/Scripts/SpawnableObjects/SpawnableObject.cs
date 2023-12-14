using Unity.Netcode;
using UnityEngine;

public abstract class SpawnableObject : NetworkBehaviour
{
    [Header("Server Data")]
    [SerializeField] private int _spawnID;

    public int SpawnID => _spawnID;

    public abstract void InitByServer();
}
