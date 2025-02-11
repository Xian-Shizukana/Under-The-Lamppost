using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using TMPro; for changing text

public class ButtonScript : MonoBehaviour
{
    public GameObject Page_1;
    public GameObject Page_2;
    public GameObject Page_3;
    public GameObject Page_4;
    public GameObject Page_5;
    public GameObject Page_6;
    public GameObject Page_7;
    public GameObject EndScreen;

    // Start is called before the first frame update
    public void Start()
    {
        Page_1.SetActive(true);
        EndScreen.SetActive(false);
        Page_2.SetActive(false);
        Page_3.SetActive(false);
        Page_4.SetActive(false);
        Page_5.SetActive(false);
        Page_6.SetActive(false);
        Page_7.SetActive(false);
     
    }

    public void PageTwo()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(true);
    }

    public void PageThree()
    {
        Page_1.SetActive(false);
        Page_3.SetActive(true);
    }

    public void PageFour()
    {
        Page_3.SetActive(false);
        Page_4.SetActive(true);
    }
    public void PageFive()
    {
        Page_4.SetActive(false);
        Page_5.SetActive(true);
    }

    public void End()
    {
        EndScreen.SetActive(true);
        Page_1.SetActive(false);
        Page_2.SetActive(false);
        Page_3.SetActive(false);
        Page_4.SetActive(false);
        Page_5.SetActive(false);
        Page_6.SetActive(false);
        Page_7.SetActive(false);
    }
}
