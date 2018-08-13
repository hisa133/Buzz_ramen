using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text.RegularExpressions;
using System;

public class Fallimage : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject gameobjectst;
    public GameObject text01;
    public Text targetText;
    ButtonClick script;
    public List<string[]> list;
    public bool flg01;
    public bool flg02;
    bool One = true;
    public GameObject GObjects ;
    public GameObject[] arr = new GameObject[12];
    public float[] gozahyou = new float[12];
    public string[] imgname = new string[12];
    // Use this for initialization
    void Start () {
        
        text01 = GameObject.Find("GetText");
        GameObject gameobject1;
        
        gameobject1 = GameObject.Find("Gamelist");
        list = gameobject1.GetComponent<CsvReaderTest>().csvDatas;
        //Debug.Log(list[1][2]+"だよ");
        gameobject = GameObject.Find("StopButton");
        gameobjectst= GameObject.Find("StartButton");
        
        int j = 1;
            for (j = 1; j < 13; j++)
            {
                arr[j-1]= GameObject.Find("shot" + Convert.ToString(j));
            }
        }

   
    

    // Update is called once per frame
    void Update() {

        string Ho;
        script = gameobject.GetComponent<ButtonClick>();
        flg01 = script.flg;
        flg02 = gameobjectst.GetComponent<ButtonClick>().flg;

        if (flg02 == true)
        {
            flg01 = false;
            flg02 = false;

        }



        //Debug.Log(flg01);
        if (flg01 == true)
        {
            if (flg01 == true && One == true)
            {

                int j = 1;

                for (j = 1; j < 12; j++)
                {

                    gozahyou[j - 1] = arr[j - 1].transform.localPosition.y;

                }

                float v = (float)35;
                //一番小さな絶対値の要素数
                int? num = GetNearestValue(gozahyou, v);
                if (num != null) {
                    Debug.Log(arr[(int)num].name);
                    string str = Regex.Replace(arr[(int)num].name, @"[^0-9]", "");
                    Debug.Log("一番近いのは" + str);
                    int num01 = Int32.Parse(str);
                    Debug.Log("一番近いのは" + list[num01][1]);
                    //ゲットした具材をテキストで表示する。
                    Ho = list[num01][1] + "\n" + "GET!!" ;

                    targetText = text01.GetComponent<Text>();
                    targetText.text = Ho;
                    targetText.color = new Color(50.0f / 255.0f, 50.0f / 255.0f, 50.0f / 255.0f, 255.0f / 255.0f);
                    
                }
                else{
                    Debug.Log("やりなおし");

                }
                //float d = System.Math.Abs(gozahyou[num] - v); ;
                //float atari = 0.06f;
                //while (d <= 0)
                //{
                //    if (gozahyou[num] > v) {
                //        atari = -0.06f;
                //    }
                //    // d が 0 になるまで繰り返し実行される
                //    for (j = 1; j < 12; j++)
                //    {
                //        arr[j-1].transform.Translate(0, atari, 0);
                //        Debug.Log("座標は" + arr[j - 1].transform.localPosition.y);
                //    }

                //    d = System.Math.Abs(arr[num].transform.localPosition.y - v);

                //}

                One = false;
            }
        }
        else
        {
            transform.Translate(0, -0.2f, 0);
            if (transform.position.y < -5.0f)
            {
                int i = 0;
                if (i > 12) { 
                     i = 1;
                }

                
                //int imgnumber= Convert.ToInt32(str);
                Vector3 pos = transform.position;
                pos.y = 15+(i*100);
                i = i + 1;
                transform.position = pos;

            }
        }
    }

   


    // 最も近い値を格納した配列の添え字を求める
    public static int ? GetNearestValue(float[] list, float v)
    {
        // 変数の宣言
        int i;      // ループ用
        int? num;    // 配列の添え字
        float minv;   // 配列値-指定値vの絶対値

        // 配列の個数が1未満の処理
        if (1 > list.Length) return -1;
        
        // 指定値と全ての配列値の差を比較
        num = 0;
        minv = System.Math.Abs(list[0] - v);
        Debug.Log(minv);
        

        for (i = 1; i < list.Length; ++i)
        {
            //Debug.Log("座標は" + list[i]+"　"+i + "の絶対値は" + System.Math.Abs(list[i] - v));
            if (System.Math.Abs(list[i] - v) < minv)
            {
                num = i;
                minv = System.Math.Abs(list[i] - v);
            }
        }
        Debug.Log(num);
        if (num <= 0 && num > 12)
        {
            num = -1;
            return num;
        } else { 
            return num;
        }
    }

}
