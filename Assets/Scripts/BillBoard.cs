using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(cam.transform);

        transform.rotation = quaternion.Euler(0f, transform.rotation.eulerAngles.y, 0f);
    }
}
