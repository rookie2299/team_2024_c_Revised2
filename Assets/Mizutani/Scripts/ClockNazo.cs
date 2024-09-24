using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ClockNazo : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI HourText;
    [SerializeField] TextMeshProUGUI MinuteText;
    [SerializeField] TextMeshProUGUI SecondText;

    private int HourCount = 18;
    private int MinuteCount = 53;
    private int SecondCount = 22;

    public GameObject ClockNazoPanel;
    public GameObject ClockClearPanel;


    // Start is called before the first frame update
    void Start()
    {
        HourText.text = HourCount.ToString("00");
        MinuteText.text = MinuteCount.ToString("00");
        SecondText.text = SecondCount.ToString("00");
    }

    public void OnClick1hUpButton()
    {
        if (HourCount > 22)
        {
            HourCount = 0;
            HourText.text = HourCount.ToString("00");
        }
        else
        {
        HourCount++;
        HourText.text = HourCount.ToString("00");
        }
    }

     public void OnClick10hUpButton()
    {
        if (HourCount > 13)
        {
            HourCount -= 14;
            HourText.text = HourCount.ToString("00");
        }
        else
        {
        HourCount += 10;
        HourText.text = HourCount.ToString("00");
        }
    }

    public void OnClick1hDownButton()
    {
        if (HourCount < 1)
        {
            HourCount = 23;
            HourText.text = HourCount.ToString("00");
        }
        else
        {
            HourCount--; 
            HourText.text = HourCount.ToString("00");
        }
    }

public void OnClick10hDownButton()
    {
        if (HourCount < 10)
        {
            HourCount += 14;
            HourText.text = HourCount.ToString("00");
        }
        else
        {
            HourCount -= 10; 
            HourText.text = HourCount.ToString("00");
        }
    }

    public void OnClick1mUpButton()
    {
        if (MinuteCount > 58)
        {
            MinuteCount = 0;
            MinuteText.text = MinuteCount.ToString("00");
        }
        else
        {
        MinuteCount++;
        MinuteText.text = MinuteCount.ToString("00");
        }
    }

    public void OnClick10mUpButton()
    {
        if (MinuteCount > 49)
        {
            MinuteCount -= 50;
            MinuteText.text = MinuteCount.ToString("00");
        }
        else
        {
        MinuteCount += 10;
        MinuteText.text = MinuteCount.ToString("00");
        }
    }

    public void OnClick1mDownButton()
    {
        if (MinuteCount < 1)
        {
            MinuteCount = 59;
            MinuteText.text = MinuteCount.ToString("00");
        }
        else
        {
            MinuteCount--; 
            MinuteText.text = MinuteCount.ToString("00");
        }
    }

    public void OnClick10mDownButton()
    {
        if (MinuteCount < 10)
        {
            MinuteCount += 50;
            MinuteText.text = MinuteCount.ToString("00");
        }
        else
        {
            MinuteCount -= 10; 
            MinuteText.text = MinuteCount.ToString("00");
        }
    }


    public void OnClick1sUpButton()
    {
        if (SecondCount > 58)
        {
            SecondCount = 0;
            SecondText.text = SecondCount.ToString("00");
        }
        else
        {
        SecondCount++;
        SecondText.text = SecondCount.ToString("00");
        }
    }

    public void OnClick10sUpButton()
    {
        if (SecondCount > 50)
        {
            SecondCount -= 50;
            SecondText.text = SecondCount.ToString("00");
        }
        else
        {
        SecondCount += 10;
        SecondText.text = SecondCount.ToString("00");
        }
    }

    public void OnClick1sDownButton()
    {
        if (SecondCount < 1)
        {
            SecondCount = 59;
            SecondText.text = SecondCount.ToString("00");
        }
        else
        {
            SecondCount--; 
            SecondText.text = SecondCount.ToString("00");
        }
    }

    public void OnClick10sDownButton()
    {
        if (SecondCount < 10)
        {
            SecondCount += 50;
            SecondText.text = SecondCount.ToString("00");
        }
        else
        {
            SecondCount -= 10; 
            SecondText.text = SecondCount.ToString("00");
        }
    }

public void OnClickSelectButton()
    {
        if (HourCount == 18 && MinuteCount == 53 && SecondCount == 22)
        {
            ClockNazoPanel.SetActive(false);
            ClockClearPanel.SetActive(true);
        }
    }

}
