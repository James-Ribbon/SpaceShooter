using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    private IInputHandler _inputHandler;

    /*private void Awake()
    {
        _inputHandler = new MobileTouchInputHandler();
    }*/

    //Dependency Injection Test > Ship.cs - 10.03.25
    public void Initialize(IInputHandler inputHandler, float movementSpeed)
    {
        _inputHandler = inputHandler;
        _movementSpeed = movementSpeed;
    }

    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        if (_inputHandler.IsInputActive())
        {
            Vector2 targetPosition = _inputHandler.GetInputDirection();
            MoveShip(targetPosition);
        }
    }

    private void MoveShip(Vector2 targetPosition)
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, _movementSpeed * Time.deltaTime);
    }
}
