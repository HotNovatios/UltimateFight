using UnityEngine;
using System.Collections;

public class LockerInter : MonoBehaviour
{
    public GameObject go;
    public Renderer rend;
    private Color curent;

    void Start()
    {
        rend = GetComponent<Renderer>();
        curent = rend.material.color;
    }
    void OnMouseEnter()
    {
        go.GetComponent<Animator>().Play("LockerDoorOpen", 0);
        rend.material.color = Color.red;
    }
    void OnMouseOver()
    {
        rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    }
    void OnMouseExit()
    {
        go.GetComponent<Animator>().Play("LockerDoorclose", 0);
        rend.material.color = curent;
    }
}