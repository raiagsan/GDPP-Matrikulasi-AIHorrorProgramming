using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static GameInputAction;

public class InputManager : MonoBehaviour, IPlayerActions
{
    private GameInputAction _InputAction;

    public UnityEvent<Vector2> OnMoveInput;
    public UnityEvent<bool> OnSprintInput;
    public UnityEvent OnInteractInput;
    public UnityEvent OnFlashlightInput;

    private void Awake()
    {
        _InputAction = new GameInputAction();
        _InputAction.Enable();
        _InputAction.Player.Enable();
        _InputAction.Player.SetCallbacks(this);
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnInteractInput?.Invoke();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        OnMoveInput?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnSprintInput?.Invoke(true);
        }
        if (context.canceled)
        {
            OnSprintInput?.Invoke(false);
        }
    }

    public void OnFlashlight(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            OnFlashlightInput?.Invoke();           
        }
    }
}
