using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TMPtest : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI testText001;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        testText001.text = count.ToString();
    }
    public void OnClickUpButton()
    {
        if (count > 22)
        {
            count = 0;
            testText001.text = count.ToString();
        }
        else
        {
        count++; //インクリメント：値を１増やす
        testText001.text = count.ToString();
        }
    }

    public void OnClickDownButton()
    {
        if (count < 1)
        {
            count = 23;
            testText001.text = count.ToString();
        }
        else
        {
            count--; 
            testText001.text = count.ToString();
        }
        
    }

  private bool buttonDownFlag = false;
  private void Update()
  {
    if (buttonDownFlag)
    {
       if (count > 22)
        {
            count = 0;
            testText001.text = count.ToString();
        }
        else
        {
        count++; 
        testText001.text = count.ToString();
        }
    }
  }
  
  public void OnButtonDown()
  {
    buttonDownFlag = true;
  }
  
  public void OnButtonUp()
  {
    buttonDownFlag = false;
  }

    
    
}
