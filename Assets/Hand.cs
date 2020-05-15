using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    private int cardsTot = 0;
    GameObject hand0, hand1, hand2, hand3;
    private bool clubs = false;
    private bool heart = false;
    private bool spades = false;
    private bool diamond = false;

    private void Start()
    {
        hand0 = GameObject.Find("Hand0");
        hand1 = GameObject.Find("Hand1");
        hand2 = GameObject.Find("Hand2");
        hand3 = GameObject.Find("Hand3");
    }

    public void AddCardToHand(string color)
    {
        if (color == "Clubs")
        {
            if (!clubs)
                clubs = true;
            else
                return;
        }

        else if (color == "Heart")
        {
            if (!heart)
                heart = true;
            else
                return;
        }

        else if (color == "Spades")
        {
            if (!spades)
                spades = true;
            else
                return;
        }

        else if (color == "Diamond")
        {
            if (!diamond)
                diamond = true;
            else
                return;
        }

        if (cardsTot == 0)
        {
            hand0.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Card" + color);
        }
        else if (cardsTot == 1)
        {
            hand1.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Card" + color);
        }
        else if (cardsTot == 2)
        {
            hand2.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Card" + color);
        }
        else if (cardsTot == 3)
        {
            hand3.GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>("Card" + color);
        }
        cardsTot++;
    }
}
