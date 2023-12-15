using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerMove _move;
    [SerializeField] private PlayerBuild _build;

    [SerializeField] private PlayerLook _look;
    [SerializeField] private PlayerShoot _shoot;

    public void Init()
    {
        transform.parent = null;
        _input.Init();
        _look.Init();
    }

    public void UpdatePlayer()
    {
        _move.MovePlayer(_input.GetMoveInput());
        _look.UpdateLook();

        
        if(_input.WasPressed1())
        {
            _shoot.Shoot();
        }

        if(_input.WasPressed2())
        {
            _build.BuildServerRpc();
        }
    }
}
