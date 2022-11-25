using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraFinishTurn : MonoBehaviour
{
    [SerializeField]
    GameObject camPoint;
    public Transform target;
    public float speed = 2f;
    quaternion quat;
    Vector3 vect;

    private void Update()
    {
        vect = target.position - transform.position;
        quat = Quaternion.LookRotation(vect);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, quat, Time.time * speed);
    }
}