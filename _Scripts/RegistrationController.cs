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
    public Toggle terms;
    public Button submit;

    public GameObject FieldPrefab;


    void errorMassage(string where, string wich)
    {
        GameObject go = GameObject.Find(where);
        GameObject errorField = Instantiate(FieldPrefab, new Vector3(go.transform.position.x-130, go.transform.position.y + 25, go.transform.position.z) , Quaternion.identity) as GameObject;
        errorField.transform.SetParent(go.transform);
        errorField.GetComponent<InputField>().text = wich;

        Destroy(errorField, 5f);

    }


    bool isFieldsEqual(string main, string equal)
    {
        if (System.String.Equals(main, equal))
        {
            return true;
        }

        //errorMassage(main, "Do not matches with conffirm field");
        return false;
    }

    bool validateEmaile(string email)
    {
        if (Regex.IsMatch(email,
              @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"))
        {
            return true;
        }
        errorMassage("E-mail", "Wrong E-mail");
        return false;
    }

    bool validatePassword(string password)
    {
        if (Regex.IsMatch(password, @"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 8,15}$"))
        {
            return true;
        }

        errorMassage("Password", "Wrong Password");

        return false;
    }



    //bool validateLogin(string Login)
    //{
    //    if (Regex.IsMatch(Login, @"^[A-Za-z0-9]{3-20}$"))
    //    {
    //        return true;
    //    }

    //    errorMassage("Invite Code", "Wrong Login");
    //    return  false;
    //}

        public  void toggleTersmOfUse()
    {
        if (terms.isOn == true)
        {
            submit.interactable = true;
        } else
        {
            submit.interactable = false;
        }

    }


    bool chekInfo()
    {
        bool check = true;

        //if (!validateLogin(login.text))
        //{
        //    check = false;
        //}


        if (!validateEmaile(Email.text))
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
        //errorMassage("Login", "Wrong Loin");
        //errorMassage("password", "Wrong Password");
        //errorMassage("email", "Wrong E-mail");
        if (chekInfo())
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        } 

    }
}
