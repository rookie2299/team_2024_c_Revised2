using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public void OnClickStartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("New Scene");
    }
   
}
