using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public AudioSource cheers;
    public AudioSource nope;
    GameObject code0, code1, code2, code3;
    int nmb0, nmb1, nmb2, nmb3;

    private void Start()
    {
        code0 = GameObject.Find("Code0");
        code1 = GameObject.Find("Code1");
        code2 = GameObject.Find("Code2");
        code3 = GameObject.Find("Code3");
        nmb0 = nmb1 = nmb2 = nmb3 = 0;
    }
    public void ArrowUpClicked(int i)
    {
        switch(i)
        {
            case 0:
                nmb0++;
                if (nmb0 == 10)
                    nmb0 = 0;
                code0.GetComponentInChildren<Text>().text = nmb0.ToString();
                break;
            case 1:
                nmb1++;
                if (nmb1 == 10)
                    nmb1 = 0;
                code1.GetComponentInChildren<Text>().text = nmb1.ToString();
                break;
            case 2:
                nmb2++;
                if (nmb2 == 10)
                    nmb2 = 0;
                code2.GetComponentInChildren<Text>().text = nmb2.ToString();
                break;
            case 3:
                nmb3++;
                if (nmb3 == 10)
                    nmb3 = 0;
                code3.GetComponentInChildren<Text>().text = nmb3.ToString();
                break;
        }
    }

    public void ArrowDownClicked(int i)
    {
        switch (i)
        {
            case 0:
                nmb0--;
                if (nmb0 == -1)
                    nmb0 = 9;
                code0.GetComponentInChildren<Text>().text = nmb0.ToString();
                break;
            case 1:
                nmb1--;
                if (nmb1 == -1)
                    nmb1 = 9;
                code1.GetComponentInChildren<Text>().text = nmb1.ToString();
                break;
            case 2:
                nmb2--;
                if (nmb2 == -1)
                    nmb2 = 9;
                code2.GetComponentInChildren<Text>().text = nmb2.ToString();
                break;
            case 3:
                nmb3--;
                if (nmb3 == -1)
                    nmb3 = 9;
                code3.GetComponentInChildren<Text>().text = nmb3.ToString();
                break;
        }
    }

    public void CheckClicked()
    {
        if (nmb0 == 4 && nmb1 == 8 && nmb2 == 7 && nmb3 == 2)
        {
            code0.GetComponentInChildren<Text>().text = "Y";
            code1.GetComponentInChildren<Text>().text = "A";
            code2.GetComponentInChildren<Text>().text = "Y";
            code3.GetComponentInChildren<Text>().text = "!";
            cheers.Play();
        }
        else
        {
            nope.Play();
        }
    }
}
