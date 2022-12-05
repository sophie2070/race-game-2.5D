using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField]
    Camera cam1;
    [SerializeField]
    Camera cam2;
    [SerializeField]
    GameObject endmenup;

    public bool finished = false;

    private void OnTriggerEnter(Collider finishhit)
    {
        if(finishhit.gameObject.CompareTag("Finish"))
        {
            finished = true;
        }
    }
    void Update()
    {
        if(finished == true)
        {
            cam1.enabled = false;
            cam2.enabled = true;
            endmenup.SetActive(true);
        }
    }
}
