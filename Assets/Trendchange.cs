using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trendchange : MonoBehaviour {
    public Text text;
    // Use this for initialization
    void Start () {
        //string[] array = new string[10];
        string[] array = { "アメリカ", "イギリス", "インド", "フランス", "イタリア", "日本","中国", "セネガル", "タイ", "アフリカ" };
  //配列の宣言&初期化
        int var;
        var = Random.Range(0, 9);
        text.text = "今の流行は\r\n" + array[var] + "だよ";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
