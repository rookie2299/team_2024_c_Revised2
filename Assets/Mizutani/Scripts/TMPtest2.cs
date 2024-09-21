using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMPtest2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI testText001;
    

 // Start is called before the first frame update
    void Start()
    {
        TMPtest tmptest; //呼ぶスクリプトにあだなつける
        GameObject obj = GameObject.Find("UpButton"); //UpButtonっていうオブジェクトを探す
        tmptest = obj.GetComponent<TMPtest>(); //付いているスクリプトを取得
    }

   

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
