using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class Test : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RectTransform rectTransform = this.GetComponent<RectTransform>();
        //サイズ変更
        rectTransform.sizeDelta = new Vector2(800, 600);
    }
}

