using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PartUIHandler : MonoBehaviour
{
    public GameObject descriptionMenu;

    private int day=0;

    public TMP_Text dayText;

    public TMP_Text bodyText;
    public TMP_Text descriptionText;

    public bool hideTextbox = false;

    public global::System.Int32 Day { get => day; set => day = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateUI()
    {

    }

    public void HideBodyMenu()
    {
        descriptionMenu.SetActive(false);
    }
    public void ShowBodyMenu()
    {
        descriptionMenu.SetActive(true);
    }
    public void UpdateBodyInfo(string pname, string pdescription)
    {
        if (hideTextbox)
        {
            ShowBodyMenu();
        }
        bodyText.text = pname;
        descriptionText.text = pdescription;
    }

    public void ResetBodyInfo()
    {
        bodyText.text = " - ";
        descriptionText.text = " - ";
        if (hideTextbox)
        {
            HideBodyMenu();
        }
    }

    public void IncreaseDay()
    {
        day++;
        dayText.text = "Day: " + day;
    }
    public void DecreaseDay()
    {
        if (day > 0)
        {
            day--;
        }
        dayText.text = "Day: " + day;
    }


    public void SetDay(int day)
    {

    }

}
