using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour {

    public InputField login;
    public InputField password;

	// Hardcoded login and password to pass login window
	public InputField authorizedLogin;
	public InputField authorizedPassword;

    void Awake()
    {
        if (login != null)
        {
            login.text = "LOG IN";
        } 
        if(password != null)
        {
            password.text = "PASSWORD";
        }
    }

    public void Submit()
    {
        // Get login and password
        if (login.text != authorizedLogin.text || password.text != authorizedPassword.text) {
			Debug.Log ("Failed");
		} else {
            SceneManager.LoadScene(1);
        }
    }
}
