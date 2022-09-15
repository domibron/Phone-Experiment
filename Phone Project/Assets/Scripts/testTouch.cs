using UnityEngine;

public class testTouch : MonoBehaviour
{

    private InputManager inputManager;
    private Camera cameraMain;


    private void Awake()
    {
        inputManager = InputManager.Instance;
        cameraMain = Camera.main;
    }

    private void OnEnable()
    {
        inputManager.OnStartTouch += Move;
    }

    private void OnDisable()
    {
        inputManager.OnEndTouch -= Move;
    }

    public void Move(Vector2 screenPosition, float time)
    {
        Vector3 screenCoordinates = new Vector3(screenPosition.x, screenPosition.y, cameraMain.nearClipPlane);
        Vector3 worldCoordinateds = cameraMain.ScreenToWorldPoint(screenCoordinates);
        worldCoordinateds.z = 0;
        transform.position = worldCoordinateds;
    }
}
