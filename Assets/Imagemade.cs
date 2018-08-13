using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.IO;

public class Imagemade : MonoBehaviour {
    [SerializeField]
    GameObject srot;

    [SerializeField]
    GameObject canvas;
    
    public List<string[]> list;
    private RectTransform hoge;
    public float x, y;　　//変更したいサイズ
    // Use this for initialization

    void Start () {
        GameObject gameobject;
        gameobject = GameObject.Find("Gamelist");
        list = gameobject.GetComponent<CsvReaderTest>().csvDatas;
       

        Texture2D texture;
        Image img;
        int cnt = list.Count;
        int i;
        for (i = 0; i < cnt; i++)
        {
            Debug.Log(list[i][3]);
        }


            for ( i = 1; i< cnt; i++) {
            srot = GameObject.Find("imagePrefab");
            canvas = GameObject.Find("Canvas");
            
            GameObject prefab = (GameObject)Resources.Load("Image");
            //(GameObject)Instantiate(srot);

            prefab.name = "shot" + Convert.ToString(i);
            prefab.transform.SetParent(canvas.transform, false);

            hoge = GameObject.Find(prefab.name).GetComponent<RectTransform>();
            x = 200;
            y = (100*i);
            
            string image01 = list[i][3];
            Debug.Log(100 * i) ;
            Debug.Log(image01);
            hoge.localPosition = new Vector3(x, y);
            texture = Resources.Load(image01) as Texture2D;
            img = GameObject.Find(prefab.name).GetComponent<Image>();
            img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            //prefab.AddComponent<Fallimage>();
        }


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
