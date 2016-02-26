using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InvalidController : MonoBehaviour {

    public InputField mail;

    void Awake()
    {
        mail.text = "E-MAIL";
    }

    public void Submit()
    {
        // Get login and password
        if (mail.text == "")
        {
            Debug.Log("Fill the input fields");
        }
        else
        {
            Debug.Log("Mail: " + mail.text);
        }
    }
}
