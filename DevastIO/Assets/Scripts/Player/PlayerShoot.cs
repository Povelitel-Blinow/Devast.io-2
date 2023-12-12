using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Gun _gun;
    // tmp
    public void Shoot() => _gun.Shoot();
}
