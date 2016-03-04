using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlaeyrGenerator : MonoBehaviour {
    public GameObject charecter;
    public Transform startPosition;

    // Dictionary<name of part, mesh>
    private Dictionary<string, Mesh> currentParts = new Dictionary<string, Mesh>();
    //Dictionry<name of part, name of mesh>;
    private Dictionary<string, string> partsNames = new Dictionary<string, string>();


    void ChangePart(string part, string meshName)
    {

    }

    void AddCharacter(Dictionary<string, string> newParts)
    {

        foreach (KeyValuePair<string, string> entry in newParts)
        {

            ChangePart(entry.Key, entry.Value);
        }

    }

    //Use this for initialization
    void Start()
    {
        Instantiate(charecter);
        AddCharacter(partsNames);
    }

    }
