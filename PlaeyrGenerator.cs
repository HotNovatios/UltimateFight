using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PlaeyrGenerator : MonoBehaviour {
    public GameObject charecter;
    public Transform startPosition;
    // Dictionary<name of part, mesh>
	public static Dictionary<string, Mesh> currentParts = new Dictionary<string, Mesh>();
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
        //Instantiate(charecter);
        //AddCharacter(partsNames);

		//TEST with adding animation
		partsNames.Add("Helm", "man_helm");
		partsNames.Add("Hair", "man_european_hair_erokez");
		partsNames.Add("Beard", "Man_european_beard_long");
		partsNames.Add("BodyProtection", "man_vest");
		partsNames.Add("Gloves", "man_gloves");
		partsNames.Add("Shorts", "man_shorts_Long");
		partsNames.Add("FootProtection", "man_Foot_protecion");

		foreach (KeyValuePair<string, string> entry in partsNames)
		{
			GameObject go = Resources.Load (entry.Key + "/" + entry.Value) as GameObject;
			currentParts.Add(entry.Key, go.transform.Find (entry.Value).GetComponent<SkinnedMeshRenderer>().sharedMesh);
			charecter.transform.Find (entry.Key).GetComponent<SkinnedMeshRenderer> ().sharedMesh = go.transform.Find (entry.Value).GetComponent<SkinnedMeshRenderer> ().sharedMesh;
		}
    }

    }
