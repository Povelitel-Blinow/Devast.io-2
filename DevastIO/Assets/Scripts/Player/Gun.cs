using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private SpawnableObject _bullet;
    [SerializeField] private GameObject _muzzle;

    public void Shoot()
    {
        SpawnRequest spawnRequest = 
            new SpawnRequest
            (
            _muzzle.transform.position,
            _muzzle.transform.rotation,
            _bullet.SpawnID
            );

        Server.Instance.SpawnObjectServerRpc(spawnRequest);
    }
}
