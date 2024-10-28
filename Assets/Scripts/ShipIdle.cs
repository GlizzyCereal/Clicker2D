using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipIdle : MonoBehaviour
{
    public float bobbingHeight = 0.5f; // The height of the bobbing
    public float bobbingSpeed = 1f; // The speed of the bobbing

    private Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = initialPosition.y + bobbingHeight * Mathf.Sin(Time.time * bobbingSpeed);
        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
    }
}
