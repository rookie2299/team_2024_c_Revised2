using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextWriter : MonoBehaviour
{
    public GameObject TextPanel;
    public List<string> textList = new List<string>();  // 表示するテキストのリスト
    public List<string> nameList = new List<string>(); 
    public Text nameuiText;
    public Text uiText;  // UnityのTextコンポーネントをアサインする
    public int i = 0;  
    public bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        if(isStart)
        {
            Cotest();
            
        }
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) )
        {
            if(i == textList.Count +1)
            {
                TextPanel.SetActive(false);
            }
            else
            {
                Cotest();
                
                Debug.Log("Cotest");
            }
            
        }
    }

    // 文章を表示させるメソッド
    public void Cotest()
    {
        TextWrite(i);  // 次のテキストを表示
        i++;
        
    }

    void TextWrite(int index)
    {
        if(index > textList.Count -1) return;
        uiText.text = textList[index];  // テキストを更新
        nameuiText.text = nameList[index];
          
    }
}