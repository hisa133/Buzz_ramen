using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scchange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Schange()
    {
        SceneManager.LoadScene("menu");
    }

    public void Schange01()
    {
        SceneManager.LoadScene("srot");
    }

    public void Schange02()
    {
        SceneManager.LoadScene("Madeit");
    }

    public void SchangeBuzz()
    {
        SceneManager.LoadScene("Bazz");
    }

    public void SchangeEnd()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void GameEnd()
    {
		        Application.Quit();
    }
}
