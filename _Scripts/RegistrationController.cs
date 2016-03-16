using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class RegistrationController : MonoBehaviour {

    public InputField login;
    public InputField password;
	public InputField confirmPassword;
    public InputField Email;
    public InputField confirmEmail;

    public GameObject FieldPrefab;


    void errorMassage(string where, string wich)
    {
        GameObject go = GameObject.Find(where);
        GameObject errorField = Instantiate(FieldPrefab, new Vector3(go.transform.position.x-160, go.transform.position.y + 30, go.transform.position.z) , Quaternion.identity) as GameObject;
        errorField.transform.SetParent(go.transform);

        Destroy(errorField, 5f);

    }


    bool isFieldsEqual(string main, string equal)
    {
        return System.String.Equals(main, equal);
    }

    bool validateEmaile(string email)
    {
        return Regex.IsMatch(email,
              @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
    }

    bool validatePassword(string password)
    {
        return Regex.IsMatch(password, @"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 8,15}$");
    }



    bool validateLogin(string Login)
    {
        return Regex.IsMatch(Login, @"^[A-Za-z0-9]{3-20}$");
    }




    bool chekInfo()
    {
        bool check = true;

        if (!validateLogin(login.text))
        {
            check = false;
        }


        if (!validateEmaile(Email.text) || !isFieldsEqual(Email.text, confirmEmail.text))
        {
            check = false;
        }

        if (!validatePassword(password.text) || !isFieldsEqual(password.text, confirmPassword.text))
        {
            check = false;
        }
        return check;
    }


    public void Submit()
    {
        errorMassage("Login", " ");
        errorMassage("Password", " ");
        errorMassage("E-mail", " ");
        if (chekInfo())
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        } 

    }
}
