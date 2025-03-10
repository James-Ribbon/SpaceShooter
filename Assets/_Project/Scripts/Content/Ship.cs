using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public ShipConfiguration configuration;
    private ShipMovement _shipMovement;

    //private float _currentThrust;
    //private float _currentFireRate;

    private void Start()
    {
        InitializeShip();
    }

    private void InitializeShip()
    {
        //_currentThrust = configuration.GetTotalThrust();
        //_currentFireRate = configuration.GetFireRate();

        //GetComponent<SpriteRenderer>().sprite = configuration.engine.partSprite;

        IInputHandler inputHandler = new MobileTouchInputHandler(); //change for PC Input Handler if needed here

        float movementSpeed = configuration.GetTotalThrust();

        _shipMovement = GetComponent<ShipMovement>();
        _shipMovement.Initialize(inputHandler, movementSpeed);

    }

    public void Fire()
    {

    }
}
