using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    public AudioSource yoohoo0 = new AudioSource();
    public AudioSource yoohoo1 = new AudioSource();
    public AudioSource yoohoo2 = new AudioSource();
    public AudioSource yoohoo3 = new AudioSource();
    public AudioSource yoohoo4 = new AudioSource();
    GameObject card;

    private void Start()
    {
        card = GameObject.Find("CardClubs");
    }
    public void TreeClicked(int i)
    {
        switch(i)
        {
            case 0:
                yoohoo0.Play();
                break;
            case 1:
                yoohoo1.Play();
                break;
            case 2:
                yoohoo2.Play();
                break;
            case 3:
                yoohoo3.Play();
                break;
            case 4:
                yoohoo4.Play();
                break;
            case 5:
                card.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("CardClubs");
                card.GetComponentInChildren<Image>().color = Color.white;
                break;
        }
    }
}
