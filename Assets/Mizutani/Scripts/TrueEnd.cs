using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueEnd : MonoBehaviour
{
    public TextWriter textWriter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(textWriter.i == textWriter.textList.Count+1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("True End");
        }
    }
}
