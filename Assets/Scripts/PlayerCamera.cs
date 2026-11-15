using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Vector3 speed;
    float xRot, yRot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        xRot += Input.GetAxis("Mouse X") * Time.deltaTime * speed.x;
        yRot -= Input.GetAxis("Mouse Y") * Time.deltaTime * speed.y;

        transform.localEulerAngles = new Vector3(yRot, xRot, 0f);
    }
}