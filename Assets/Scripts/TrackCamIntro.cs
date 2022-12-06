using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TrackCamIntro : MonoBehaviour
{
    float timer;
    [SerializeField]
    Vector3[] startpoint;
    [SerializeField]
    quaternion[] startpointrot;
    [SerializeField]
    Camera cam;
    bool timerOn = true;
    [SerializeField]
    Camera maincam;
    bool cam1D = true;
    bool cam2D = true;
    [SerializeField]
    GameObject canvasUi;
    void Update()
    {
        if (timerOn == true)
        {
            timer += Time.deltaTime;
            cam.transform.Translate(0 ,0 ,35 * Time.deltaTime);
        }
            if(timer >= 1.5 && cam1D == true)
        {
            cam.transform.position = startpoint[1];
            cam.transform.rotation = startpointrot[1];
            cam1D = false;

        }
        if (timer >= 3 && cam2D == true)
        {
            cam.transform.position = startpoint[2];
            cam.transform.rotation = startpointrot[2];
            cam2D = false;
        }
        if (timer >=  4.5)
        {
            timerOn = false;
            cam.enabled = false;
            maincam.enabled = true;
            canvasUi.SetActive(true);
        }
    }
}
