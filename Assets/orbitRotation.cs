using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitRotation : MonoBehaviour
{
    public float orbitSpeed = 0.5f;
    public float orbitRadius = 20.0f;
    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationAxis = new Vector3(0, 1, 0);  // Define rotation axis as Y-axis

        // Orbit around initial point
        Vector3 orbitPosition = initialPosition + new Vector3(Mathf.Cos(Time.time * orbitSpeed), 0, Mathf.Sin(Time.time * orbitSpeed)) * orbitRadius;
        transform.position = orbitPosition;
    }
}
