using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject background;

    private void Start()
    {
        
    }

    private void ScaleBackground()
    {
#if PLATFORM_ANDROID



#endif
    }

    private void ScaleAndroidBackground()
    {
        float screenHeight = Screen.height;
        float screenWidth = Screen.width;
        float screenRatio = screenWidth/screenHeight;

        Debug.Log($"Device Screen Size (W/H): {screenWidth}, {screenHeight} :: RATIO: {screenRatio}");

        mainCamera.aspect = screenRatio;
    }
}
