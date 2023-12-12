using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private GameObject _muzzle;
    public void Shoot()
    {
        /*
        Bullet bullet = Instantiate(_bullet, _muzzle.transform.position, _muzzle.transform.rotation);
        
        bullet.NetworkObject.Spawn();*/

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
