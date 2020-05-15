using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Container : MonoBehaviour
{
    public AudioSource nope = new AudioSource();
    public AudioSource ding = new AudioSource();
    GameObject quiz, answer0, answer1, answer2, answer3;
    private float counter = 0f;
    int round = 0;
    GameObject card;

    private void Start()
    {
        quiz = GameObject.Find("Quiz");
        answer0 = GameObject.Find("Answer0");
        answer1 = GameObject.Find("Answer1");
        answer2 = GameObject.Find("Answer2");
        answer3 = GameObject.Find("Answer3");
        card = GameObject.Find("CardDiamond");
    }

    private void Update()
    {
        if (counter > 0)
        {
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                answer0.GetComponentInChildren<Image>().color = Color.white;
                answer1.GetComponentInChildren<Image>().color = Color.white;
                answer2.GetComponentInChildren<Image>().color = Color.white;
                answer3.GetComponentInChildren<Image>().color = Color.white;
                answer2.GetComponentInChildren<Text>().fontSize = 18;
                round++;
                switch (round)
                {
                    case 1:
                        quiz.GetComponentInChildren<Text>().text = "What is 2+2?";
                        answer0.GetComponentInChildren<Text>().text = "2";
                        answer1.GetComponentInChildren<Text>().text = "4";
                        answer2.GetComponentInChildren<Text>().text = "6";
                        answer3.GetComponentInChildren<Text>().text = "8";
                        break;


                    case 2:
                        quiz.GetComponentInChildren<Text>().text = "What is 3+3?";
                        answer0.GetComponentInChildren<Text>().text = "2";
                        answer1.GetComponentInChildren<Text>().text = "4";
                        answer2.GetComponentInChildren<Text>().text = "6";
                        answer3.GetComponentInChildren<Text>().text = "8";
                        break;

                    case 3:
                        quiz.GetComponentInChildren<Text>().text = "What is the main difference between a Serial Peripheral Interface (SPI) communicational bus protocol and an Inter-Integrated Circuit (I2C)?";
                        answer0.GetComponentInChildren<Text>().text = "Yes";
                        answer1.GetComponentInChildren<Text>().text = "No";
                        answer2.GetComponentInChildren<Text>().text = "SPI is full duplex and can only have one master attached to a bus, whereas I2C is half-duplex and can have more than one master attached to a bus";
                        answer3.GetComponentInChildren<Text>().text = "One of them is a Cookie";
                        answer2.GetComponentInChildren<Text>().fontSize = 14;
                        break;

                    case 4:
                        quiz.GetComponentInChildren<Text>().text = "Why do programmers wear glasses?";
                        answer0.GetComponentInChildren<Text>().text = "Because they can't\nC-sharp";
                        answer1.GetComponentInChildren<Text>().text = "Because they can't\nD-soft";
                        answer2.GetComponentInChildren<Text>().text = "Because they can't\nA-plus";
                        answer3.GetComponentInChildren<Text>().text = "Because they can't\nB-movie";
                        break;

                    case 5:
                        quiz.GetComponentInChildren<Text>().text = "What is the hottest thing on Earth?";
                        answer0.GetComponentInChildren<Text>().text = "An inferno";
                        answer1.GetComponentInChildren<Text>().text = "Lava";
                        answer2.GetComponentInChildren<Text>().text = "The sun";
                        answer3.GetComponentInChildren<Text>().text = "Una";
                        break;

                    case 6:
                        quiz.GetComponentInChildren<Text>().text = "What is Una's favorite catchphrase?";
                        answer0.GetComponentInChildren<Text>().text = "Whoo-Pah!";
                        answer1.GetComponentInChildren<Text>().text = "Cha-ching!";
                        answer2.GetComponentInChildren<Text>().text = "Ba-dum ba tss";
                        answer3.GetComponentInChildren<Text>().text = "All of the above";
                        break;
                }
            }
        }
    }
    public void AnswerClicked(int i)
    {
        switch(round)
        {
            case 0:
                if (i == 0)
                    answer0.GetComponentInChildren<Image>().color = Color.green;
                else if (i == 1)
                    answer1.GetComponentInChildren<Image>().color = Color.green;
                else if (i == 2)
                    answer2.GetComponentInChildren<Image>().color = Color.green;
                else if (i == 3)
                    answer3.GetComponentInChildren<Image>().color = Color.green;
                ding.Play();
                counter = 2;
                break;

            case 1:
                if (i == 1)
                {
                    answer1.GetComponentInChildren<Image>().color = Color.green;
                    ding.Play();
                    counter = 2;
                }
                else
                {
                    nope.Play();
                }
                break;

            case 2:
                if (i == 2)
                {
                    answer2.GetComponentInChildren<Image>().color = Color.green;
                    ding.Play();
                    counter = 2;
                }
                else
                {
                    nope.Play();
                }
                break;

            case 3:
                if (i == 2)
                {
                    answer2.GetComponentInChildren<Image>().color = Color.green;
                    ding.Play();
                    counter = 2;
                }
                else
                {
                    nope.Play();
                }
                break;

            case 4:
                if (i == 0)
                {
                    answer0.GetComponentInChildren<Image>().color = Color.green;
                    ding.Play();
                    counter = 2;
                }
                else
                {
                    nope.Play();
                }
                break;

            case 5:
                if (i == 3)
                {
                    answer3.GetComponentInChildren<Image>().color = Color.green;
                    ding.Play();
                    counter = 2;
                }
                else
                {
                    nope.Play();
                }
                break;

            case 6:
                if (i == 3)
                {
                    answer3.GetComponentInChildren<Image>().color = Color.green;
                    ding.Play();
                    card.GetComponentInChildren<Image>().enabled = true;
                }
                else
                {
                    nope.Play();
                }
                break;
        }
    }
}
