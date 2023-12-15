using Unity.Netcode;
using UnityEngine;

public class Gun : NetworkBehaviour
{
    [SerializeField] private SpawnableObject _bullet;
    [SerializeField] private GameObject _muzzle;

    public void Shoot()
    {
        SpawnObjectServerRpc();
    }

    [ServerRpc]
    private void SpawnObjectServerRpc()
    {
        SpawnableObject newInstantiatedObject
            = Instantiate(_bullet, _muzzle.transform.position, _muzzle.transform.rotation);

        newInstantiatedObject.NetworkObject.Spawn();
        newInstantiatedObject.InitByServer();
    }
}