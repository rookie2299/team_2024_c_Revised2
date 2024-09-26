using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public Camera currentCamera;
    public Camera targetCamera;
    public GameObject backButton;
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        backButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButtonOnclick()
    {
        currentCamera.gameObject.SetActive(false);
        targetCamera.gameObject.SetActive(true);
        Panel.SetActive(true);
        backButton.SetActive(false);
    }
}
