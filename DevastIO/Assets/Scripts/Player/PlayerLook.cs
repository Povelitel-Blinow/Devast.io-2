using Unity.Netcode;
using UnityEngine;

public class PlayerLook : NetworkBehaviour
{
    [SerializeField] private CameraFollow _cameraPrefab;

    private CameraFollow _camera;

    public void Init()
    {
        _camera = Instantiate(_cameraPrefab);
        _camera.Init(gameObject);
    }

    public void UpdateLook() => _camera.UpdateCamera();
}
