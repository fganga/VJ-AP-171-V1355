using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayFabLogin : MonoBehaviour
{
    public InputField txt_email,txt_password;
    public void Start()
    {
        /*
        if (string.IsNullOrEmpty(PlayFabSettings.staticSettings.TitleId)){
           
            PlayFabSettings.staticSettings.TitleId = "42";
        }
        var request = new LoginWithCustomIDRequest { CustomId = "JuanMir23", CreateAccount = true};
        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
        */
    }
    public void LoginEmail(){
        string user_email = txt_email.text;
        string user_password = txt_password.text;
        //Debug.Log("Click en el botón!. Email ingresado es " + user_email);
        var request = new LoginWithEmailAddressRequest { Email = user_email, Password = user_password};
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result)
    {
        //Debug.Log("Login OK!");
        SceneManager.LoadScene("Scenes/MainScene");
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("----- Login Error -----");
        Debug.LogError(error.GenerateErrorReport());
    }
}