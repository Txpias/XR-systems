using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Transform mainCamera;
    public Transform lensCamera;
    public Camera mainCamera2;
    private float normalFov;

    void Start()
    {
        normalFov = mainCamera2.fieldOfView;

    }

    public void AttachMainCameraViewOnLens()
    {
        mainCamera2.fieldOfView = normalFov + 10f;
        transform.rotation = mainCamera.rotation;
    }

    public void SwitchBackToLensView()
    {
        if (mainCamera2.fieldOfView > 60) {
            Debug.Log("Fov was chaged");
        }
        transform.rotation = lensCamera.rotation;
        mainCamera2.fieldOfView = normalFov;
    }

}
