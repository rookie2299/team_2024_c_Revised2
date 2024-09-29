using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectText : MonoBehaviour
{

    //public TextWriter textWriter;   //TextWriterスクリプト
    public GameObject TextPanel;

    public void OnMouseDown()
    {
        //textWriter.Cotest();    //TextWriterスクリプトCotestメソッドを呼び出す
        TextPanel.SetActive(true);
    }
    
}
