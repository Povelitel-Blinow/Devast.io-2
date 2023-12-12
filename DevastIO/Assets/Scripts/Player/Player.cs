using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput _input;
    [SerializeField] private PlayerMove _move;

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

        if(_input.WasPressed())
        {
            _shoot.Shoot();
        }
    }
}
