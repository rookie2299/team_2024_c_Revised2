using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPanel : MonoBehaviour
{
    public TextWriter textWriter;
    public GameObject ePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textWriter.i == textWriter.textList.Count+1)
        {
            ePanel.SetActive(true);
        }
    }
}
