using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNavigator : MonoBehaviour
{
    [SerializeField]
    GameObject menu01;
    [SerializeField]
    GameObject menu02;
    [SerializeField]
    GameObject menu03;
    [SerializeField]
    GameObject menu04;

    public void MenuToggel01()
    {
        menu01.SetActive(!menu02.activeSelf);
        menu02.SetActive(!menu01.activeSelf);
    }
    public void MenuToggel02()
    {
        menu02.SetActive(!menu03.activeSelf);
        menu03.SetActive(!menu02.activeSelf);
    }
    public void MenuToggel03()
    {
        menu03.SetActive(!menu04.activeSelf);
        menu04.SetActive(!menu03.activeSelf);
    }
    public void MenuBack01()
    {
        menu02.SetActive(!menu01.activeSelf);
        menu01.SetActive(!menu02.activeSelf);
    }
    public void MenuBack02()
    {
        menu03.SetActive(!menu02.activeSelf);
        menu02.SetActive(!menu03.activeSelf);
    }
    public void MenuBack03()
    {
        menu04.SetActive(!menu03.activeSelf);
        menu03.SetActive(!menu04.activeSelf);
    }
}
