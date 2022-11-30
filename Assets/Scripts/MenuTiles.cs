using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTiles : MonoBehaviour
{
    Rigidbody Rigidbody;
    public void TileMove()
    {
        Vector2 move = new Vector2(1 * Time.deltaTime,0);
        Debug.Log("move");
        Rigidbody = GetComponent<Rigidbody>();
        transform.position = move;
    }
}
