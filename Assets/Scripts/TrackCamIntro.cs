using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TrackCamIntro : MonoBehaviour
{
    float timer;
    [SerializeField]
    Vector3[] startpoint;
    //quaternion startpointrot = (0,180,0);
    //quaternion startpointrot2 = (0,280,0);
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
            cam.transform.Rotate(0 ,90 ,0 ,0);
            cam1D = false;

        }
        if (timer >= 3 && cam2D == true)
        {
            cam.transform.position = startpoint[2];
            cam.transform.Rotate(0, 100, 0, 0);
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
