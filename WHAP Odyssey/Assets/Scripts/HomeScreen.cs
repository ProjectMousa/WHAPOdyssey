using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeScreen : MonoBehaviour {
    GameObject LoadGameButton;

    // Use this for initialization
    void Awake() {
        LoadGameButton = GameObject.Find("LoadGame");
    }

	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
 
    }

    public void NewGame() {
        SceneManager.LoadScene("mainLevel");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
