using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedLight : MonoBehaviour
{
    public AudioSource light = new AudioSource();
    private float counter = 0f;
    GameObject arrow, bg;

    public void Start()
    {
        arrow = GameObject.Find("Arrow0");
        bg = GameObject.Find("Bg0");
        arrow.GetComponentInChildren<Button>().enabled = false;
    }
    private void Update()
    {
        if (counter > 0)
        {
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                arrow.GetComponentInChildren<Button>().enabled = true;
                arrow.GetComponentInChildren<Image>().enabled = true;
                bg.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>("Bg0Green");
            }
        }
    }
    public void LightClicked()
    {
        light.Play();
        counter = 3.35f;
    }

    
}
