using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfRotation : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationAxis = new Vector3(0, 1, 0);  // Define rotation axis as Y-axis
        float yRotation = rotationSpeed * Time.deltaTime;

        // Rotate around Y-axis
        transform.Rotate(rotationAxis * yRotation, Space.World);
    }

}
