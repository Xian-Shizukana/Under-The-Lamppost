using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// using TMPro; for changing text

public class ButtonScript : MonoBehaviour
{
    public GameObject Page_1;
    public GameObject Page_2;

    public GameObject EndScreen;

    // Start is called before the first frame update
    void Start()
    {
        Page_1.SetActive(true);
        Page_2.SetActive(false);
        EndScreen.SetActive(false);
    }

    public void Restart()
    {
        Page_1.SetActive(true);
        Page_2.SetActive(false);
        EndScreen.SetActive(false);
    }

    public void PageTwo()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(true);
    }

    public void End()
    {
        Page_1.SetActive(false);
        Page_2.SetActive(false);
        EndScreen.SetActive(true);
    }
}
