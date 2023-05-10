using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float rotationSpeed = 5f;
    [SerializeField] private float lookUpLimit = 180f;
    [SerializeField] private float lookDownLimit = -180f;

    private bool isMovingFast;

    void Update()
    {
        // Check if shift key is held down for faster movement
        isMovingFast = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        // Move the camera
        float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime;
        float movementMultiplier = isMovingFast ? 5f : 1f;
        transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement) * movementSpeed * movementMultiplier);

        // Rotate the camera
        float horizontalRotation = Input.GetAxis("Mouse X") * Time.deltaTime;
        float verticalRotation = Input.GetAxis("Mouse Y") * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontalRotation * rotationSpeed);
        transform.Rotate(Vector3.left, verticalRotation * rotationSpeed);

        // Limit vertical rotation
        Vector3 currentRotation = transform.localEulerAngles;
        currentRotation.x = Mathf.Clamp(currentRotation.x, lookDownLimit, lookUpLimit);
        transform.localEulerAngles = currentRotation;
    }
}
