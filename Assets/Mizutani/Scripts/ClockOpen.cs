using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClockOpen : MonoBehaviour , IPointerClickHandler
{
    public GameObject ClockNazoPanel;
    public void OnPointerClick(PointerEventData eventData)
    {
        ClockNazoPanel.SetActive(true);
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
