using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Neighbour : MonoBehaviour
{
    public AudioSource nope;
    public AudioSource ding;
    public AudioSource red;
    public AudioSource green;
    public AudioSource blue;
    public AudioSource yellow;
    GameObject[] colors = new GameObject[4];
    GameObject card;
    private static int codeLength = 7;
    private static int[] code = new int[codeLength];
    private static int currentRound = 0;
    private static int currentClicks = 0;
    private float counter = 0f;
    public static bool simonPlaying = false;
    private static bool hasEnteredOncePick = false;
    private static bool hasEnteredOnce = false;
    private void Start()
    {
        colors[0] = GameObject.Find("SimonRed");
        colors[1] = GameObject.Find("SimonGreen");
        colors[2] = GameObject.Find("SimonBlue");
        colors[3] = GameObject.Find("SimonYellow");
        colors[0].GetComponentInChildren<Image>().color = Color.red;
        colors[1].GetComponentInChildren<Image>().color = Color.green;
        colors[2].GetComponentInChildren<Image>().color = Color.blue;
        colors[3].GetComponentInChildren<Image>().color = Color.yellow;
        card = GameObject.Find("CardHeart");
    }
    public void SimonStart()
    {
        simonPlaying = true;
        currentRound = 1;
        currentClicks = 0;
        counter = 0;
        for (int i = 0; i < codeLength; i++)
        {
            code[i] = Random.Range(0, 4);
            for (int ii = 0; ii < 10000; ii++)
            {

            }
        }
    }

    public void Update()
    {
        if (simonPlaying)
        {
            counter += Time.deltaTime;
            if (currentClicks < currentRound)
            {
                if (counter > 0.8f + (currentClicks * 1.1f) && counter < 1.5f + (currentClicks * 1.1f))
                {
                    if (!hasEnteredOncePick)
                    {
                        hasEnteredOncePick = true;
                        if (code[currentClicks] == 0)
                            red.Play();
                        else if (code[currentClicks] == 1)
                            green.Play();
                        else if (code[currentClicks] == 2)
                            blue.Play();
                        else if (code[currentClicks] == 3)
                            yellow.Play();

                        colors[code[currentClicks]].GetComponentInChildren<Image>().color = Color.white;
                        hasEnteredOnce = false;
                    }
                }

                else if (counter > 0.5f)
                {
                    if (!hasEnteredOnce)
                    {
                        hasEnteredOnce = true;
                        colors[0].GetComponentInChildren<Image>().color = Color.red;
                        colors[1].GetComponentInChildren<Image>().color = Color.green;
                        colors[2].GetComponentInChildren<Image>().color = Color.blue;
                        colors[3].GetComponentInChildren<Image>().color = Color.yellow;
                        currentClicks++;
                        hasEnteredOncePick = false;
                    }
                }
            }
            else
            {
                currentClicks = 0;
            }
        }
    }

    public void SimonClicked(int i)
    {
        if (simonPlaying)
        {
            if (i == code[currentClicks])
            {
                ding.Play();
                currentClicks++;
                if (currentClicks == 7)
                {
                    simonPlaying = false;
                    card.GetComponentInChildren<Image>().enabled = true;
                }

                else if (currentClicks == currentRound)
                {
                    currentClicks = 0;
                    currentRound++;
                    counter = 0;
                }
            }
            else
            {
                nope.Play();
                SimonStart();
            }
        }
    }
}
