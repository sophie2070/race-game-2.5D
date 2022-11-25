using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishEndScreen : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider finishhit)
    {
        if (finishhit.gameObject.CompareTag("Finish"))
        {
            
        }
    }
}
