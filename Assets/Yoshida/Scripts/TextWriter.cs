using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextWriter : MonoBehaviour
{
    public List<string> textList = new List<string>();  // 表示するテキストのリスト
    public Text uiText;  // UnityのTextコンポーネントをアサインする
    public int i = 0;  
    private bool isShow = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && isShow)
        {
            Cotest();
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
          uiText.text = textList[index];  // テキストを更新
          isShow = true;  // テキストが表示されている状態にする
    }
}