using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;


public class Retryitem : MonoBehaviour {
    
    public GameObject[] arr = new GameObject[4];

    // Use this for initialization
    void Start () {
        //arr[0] = GameObject.Find("Image (5)");

        int i = 0;
        for (i = 1; i < 5; i++)
        {
            arr[i - 1] = GameObject.Find("Image (" + Convert.ToString(i + 4) + ")");
            //Debug.Log(arr[i - 1].name);
        }
    }

    public void OnClick()
    
        {
        int i = 0;

        Image img;
        //Texture2D texture;
        //string st;

        for (i = 1; i < 5; i++)
            {
            //Debug.Log(arr[i-1].name);
            img = GameObject.Find(arr[i-1].name).GetComponent<Image>();

            img.sprite = null;
            img.color = new Color(130.0f / 255.0f, 223f / 255.0f, 169f / 255.0f, 255.0f / 255.0f);
        }
        }

    // Update is called once per frame
    void Update () {
		
	}
}
