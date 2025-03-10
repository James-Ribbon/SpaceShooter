using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInputHandler
{
    Vector2 GetInputDirection();
    bool IsInputActive();
}

public class MobileTouchInputHandler : IInputHandler
{
    private int _touchID = -1;
    private Camera _mainCamera;

    public MobileTouchInputHandler()
    {
        _mainCamera = Camera.main;
#if UNITY_EDITOR
        if (_mainCamera == null)
        {
            Debug.LogError("No main camera found in the scene");
        }
#endif
    }

    public Vector2 GetInputDirection()
    {
        if (IsInputActive())
        {
            foreach (var touch in Input.touches)
            {
                if (touch.fingerId == _touchID)
                {
                    Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    return touchPosition;
                }
            }
        }
        return Vector2.zero;
    }

    public bool IsInputActive()
    {
        if (_touchID != -1)
        {
            foreach (var touch in Input.touches)
            {
                if (touch.fingerId == _touchID)// && touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
                {
                    return true;
                }
            }
            
            _touchID = -1;
        }
        else
        {
            // Find new touch if nothing is being tracked
            foreach (var touch in Input.touches)
            {
                if (touch.phase == TouchPhase.Began)
                {
                    _touchID = touch.fingerId;
                    return true;
                }
            }
        }
        return false;
    }
    
}
