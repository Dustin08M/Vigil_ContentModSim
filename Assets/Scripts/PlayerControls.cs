using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private int m_speed;
    [SerializeField] private float SmoothValue;
    [SerializeField] private Camera MainCamera;

    [SerializeField] private bool isControllerEnabled;
    [SerializeField] private bool isPlayerMoving;
    private void Update()
    {
        if (isControllerEnabled)
        {
            MovePlayer();
            FaceMouse();
        }
    }

    void FaceMouse()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray CameraRay = MainCamera.ScreenPointToRay(Input.mousePosition);

        if (plane.Raycast(CameraRay, out float distance))
        {
            Vector3 targetPoint = CameraRay.GetPoint(distance);
            Debug.DrawLine(CameraRay.origin, targetPoint, Color.red);
            transform.LookAt(targetPoint);
        }
    }

    void MovePlayer()
    {
        Vector3 movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) /**m_speed *Time.deltaTime*/;
        isPlayerMoving = true;

        if (movementInput.magnitude > 1f) movementInput.Normalize();

        movementInput *= m_speed * Time.deltaTime;
        Vector3 CurrentPlayerPos = transform.position += movementInput;

        transform.position = Vector3.Lerp(transform.position, CurrentPlayerPos, SmoothValue);

        //Default
        //transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * m_speed *Time.deltaTime);
    }
}
