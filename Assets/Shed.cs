using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shed : MonoBehaviour
{
    public AudioSource knock = new AudioSource();
    GameObject bulb0, bulb1, bulb2, bulb3;
    bool light0 = false, light1 = false, light2 = false, light3 = false;
    GameObject card;

    private void Start()
    {
        bulb0 = GameObject.Find("Bulb0");
        bulb1 = GameObject.Find("Bulb1");
        bulb2 = GameObject.Find("Bulb2");
        bulb3 = GameObject.Find("Bulb3");
        card = GameObject.Find("CardSpades");
    }

    public void BulbClicked(int i)
    {
        if (i == 0)
        {
            light0 = !light0;
            if (light0)
            {
                bulb0.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOn");
            }
            else
            {
                bulb0.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOff");
            }
        }
        else if (i == 1)
        {
            light1 = !light1;
            if (light1)
            {
                bulb1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOn");
            }
            else
            {
                bulb1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOff");
            }
        }
        else if (i == 2)
        {
            light2 = !light2;
            if (light2)
            {
                bulb2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOn");
            }
            else
            {
                bulb2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOff");
            }
        }
        else if (i == 3)
        {
            light3 = !light3;
            if (light3)
            {
                bulb3.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOn");
            }
            else
            {
                bulb3.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("BulbOff");
            }
        }
        else
        {
            knock.Play();
            if (light0 && light1 && light2 && light3)
            {
                card.GetComponentInChildren<Image>().enabled = true;
            }
        }
    }
}
