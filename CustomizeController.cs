using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CustomizeController : MonoBehaviour {
    public GameObject player;

    public List<Mesh> hairStyles = new List<Mesh>();
    private int currentStyle;

    void Start()
    {

    }


    void ChangeHaireStyle()
    {
        
       SkinnedMeshRenderer hairMeshRender = player.transform.FindChild("Haire").GetComponent<SkinnedMeshRenderer>();
        hairMeshRender.sharedMesh = hairStyles[0];
    }

    void NexStyle(int currentStyle)
    {

    }

}
