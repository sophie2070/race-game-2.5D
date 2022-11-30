using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;

public class MenuTiles : MonoBehaviour
{
    [SerializeField]
    GameObject moveto;
    [SerializeField]
    GameObject bar;

    Vector2 movetoposition;

    private void Awake()
    {
        movetoposition =moveto.transform.position;
    }
    public void MoveTo()
    {
        bar.transform.position = movetoposition;

    }
}
