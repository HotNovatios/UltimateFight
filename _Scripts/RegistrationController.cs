using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RegistrationController : MonoBehaviour {

    public InputField login;
    public InputField password;
	public InputField confirmPassword;
    public InputField mail;

	public GameObject characterEditor;
	public GameObject avatarsImage;

    void Awake()
    {
        login.text = "LOG IN";
        password.text = "PASSWORD";
		confirmPassword.text = "CONFIRM PASSWORD";
        mail.text = "E-MAIL";

		characterEditor.SetActive (false);
    }

    public void Submit()
    {
        // Get login and password
        if (login.text == "" || password.text == "" || mail.text == "")
        {
            Debug.Log("Fill the input fields");
        }
		else if(password.text != confirmPassword.text){
			Debug.Log("Passwords do NOT match");
		}
		else {
            Debug.Log("Success");
			gameObject.SetActive(false);
			characterEditor.SetActive(true);
			avatarsImage.SetActive (false);
        }
    }
}
