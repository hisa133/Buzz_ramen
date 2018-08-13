using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Prefabtest : MonoBehaviour {
    private string musicName; // 読み込む譜面の名前
    private string level; // 難易度
    private TextAsset csvFile; // CSVファイル
    public List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト
    private int height = 0; // CSVの行数

    int i =1;
    GameObject canvas;
    private RectTransform hoge;
    public float x, y;　　//変更したいサイズ
    public List<string[]> list;
    // Use this for initialization
    void Start () {
        //CSV読み込み
        musicName = "test"; // 曲名
        //level = "0"; // 難易度
        csvFile = Resources.Load("CSV/" + musicName) as TextAsset; /* Resouces/CSV下のCSV読み込み */
        StringReader reader = new StringReader(csvFile.text);

        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            csvDatas.Add(line.Split(',')); // リストに入れる
            height++; // 行数加算
        }
        //Debug.Log(csvDatas[1][3]);
        canvas = GameObject.Find("Canvas");
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("Image");
        // Cubeプレハブを元に、インスタンスを生成、
        Texture2D texture;
        Image img;

        int cnt = csvDatas.Count;
        x = 200;
        for (i = 1; i < cnt; i++)
        {

            y = (100 * i);
            GameObject newimg = Instantiate(obj, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
            newimg.name = "shot" + Convert.ToString(i);
            newimg.transform.SetParent(canvas.transform, false);
            
            string image01 = csvDatas[i][3];
            texture = Resources.Load(image01) as Texture2D;
            img = GameObject.Find(newimg.name).GetComponent<Image>();
            img.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        }

 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
