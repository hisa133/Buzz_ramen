using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class CsvReaderTest : MonoBehaviour
{

    private string musicName; // 読み込む譜面の名前
    private string level; // 難易度
    private TextAsset csvFile; // CSVファイル
    public List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト
    private int height = 0; // CSVの行数

    void Start()
    {
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
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}