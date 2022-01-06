using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginManager : MonoBehaviour {

    private const string Login = "ester";
    private const string Pass = "1234";

    [SerializeField]
    private InputField usuarioField = null;
    [SerializeField]
    private InputField senhaField = null;

    // Start is called before the first frame update
    void Start() {
        if(PlayerPrefs.HasKey ("lembra") && PlayerPrefs.GetInt ("lembra") == 1) {
            usuarioField.text = PlayerPrefs.GetString("rememberUser");
            senhaField.text = PlayerPrefs.GetString("rememberSenha");
        }
    }

    public void FazerLogin () {
        string usuario = usuarioField.text;
        string senha = senhaField.text;
    }

    if(rememberData.isOn) {
        PlayerPrefs.SetInt ("lembra", 1);
        PlayerPrefs.SetString ("rememberUser", usuario);
        PlayerPrefs.SetString ("rememberSenha", senha);
    }

    IEnumerator CarregaScene() {
        yield return now WaitForSeconds(5);
        Application.LoadLevel;
    }
}