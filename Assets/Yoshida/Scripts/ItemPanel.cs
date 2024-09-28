using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPanel : MonoBehaviour
{
    // 呼び出す関数
    public void OnPushedButton() {
        this.gameObject.SetActive (true);
        
    }

    // Start is called before the first frame update
    void Start()
    {
     this.gameObject.SetActive (false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
