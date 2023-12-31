using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private InputActions _inputActions;
    public InputActions.OnFootActions OnFoot;

    public void Init()
    {
        _inputActions = new InputActions();
        OnFoot = _inputActions.OnFoot;

        OnFoot.Enable();
    }

    public Vector2 GetMoveInput() => OnFoot.Move.ReadValue<Vector2>();

    public bool WasPressed1() => OnFoot.Interact.WasPressedThisFrame();

    public bool WasPressed2() => OnFoot.Build.WasPressedThisFrame();
}
