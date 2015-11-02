using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
    public float CameraVelocity, Border, ZoomSpeed, ZoomMin, ZoomMax;
    public Camera activeCamera;
    private float border, mouseX, mouseY;


    void Start()
    {
        border = Screen.height * 0.01f * Border;
    }

    void Update()
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;

        // Left
        if (mouseX < border)
        {
            activeCamera.transform.Translate((Vector3.left * (CameraVelocity * 3)) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            activeCamera.transform.Translate((Vector3.left * (CameraVelocity * 3)) * Time.deltaTime);
        }

        // Right
        if (mouseX > Screen.width - border)
        {
            activeCamera.transform.Translate((Vector3.right * (CameraVelocity * 3)) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            activeCamera.transform.Translate((Vector3.right * (CameraVelocity * 3)) * Time.deltaTime);
        }

        // Up
        if (mouseY > Screen.height - border)
        {
            Vector3 forward = activeCamera.transform.forward;
            forward.y = 0;
            activeCamera.transform.position = activeCamera.transform.position + ((CameraVelocity * 0.1f) * forward);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forward = activeCamera.transform.forward;
            forward.y = 0;
            activeCamera.transform.position = activeCamera.transform.position + ((CameraVelocity * 0.1f) * forward);
        }

        // Down
        if (mouseY < border)
        {
            Vector3 forward = activeCamera.transform.forward;
            forward.y = 0;
            activeCamera.transform.position = activeCamera.transform.position - ((CameraVelocity *  0.1f) * forward);       
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 forward = activeCamera.transform.forward;
            forward.y = 0;
            activeCamera.transform.position = activeCamera.transform.position - ((CameraVelocity * 0.1f) * forward);
        }

        // Zoom down
        if (activeCamera.orthographicSize > ZoomMin && Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            activeCamera.orthographicSize -= ZoomSpeed * Time.deltaTime;
            if (activeCamera.orthographicSize <= ZoomMin) activeCamera.orthographicSize = ZoomMin;
        }

        // Zoom up
        if (activeCamera.orthographicSize < ZoomMax && Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            activeCamera.orthographicSize += ZoomSpeed * Time.deltaTime;
            if (activeCamera.orthographicSize >= ZoomMax) activeCamera.orthographicSize = ZoomMax;
        }
    }
}
