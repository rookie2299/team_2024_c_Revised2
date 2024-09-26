using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockerBackButton : MonoBehaviour
{
    public Camera currentCamera;
    public Camera targetCamera;
    public GameObject backButton;
    public GameObject Panel;
    public GameObject InputField;

    // Start is called before the first frame update
    void Start()
    {
        backButton.SetActive(false);
        InputField.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LockerBackButtonOnclick()
    {
        currentCamera.gameObject.SetActive(false);
        targetCamera.gameObject.SetActive(true);
        Panel.SetActive(true);
        backButton.SetActive(false);
        InputField.SetActive(false);
    }
}
