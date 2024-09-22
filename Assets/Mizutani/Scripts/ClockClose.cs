using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockClose : MonoBehaviour
{
    public GameObject ClockNazoPanel;
    public void OnClickCloseButton()
    {
        ClockNazoPanel.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
