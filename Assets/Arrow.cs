using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private GameObject cam;
    private GameObject image;
    public AudioSource birthday;

    public void StartGameClicked()
    {
        cam = GameObject.Find("Main Camera");
        image = GameObject.Find("Bg0");
        cam.transform.position = new Vector3(image.transform.position.x, image.transform.position.y, -10);
        birthday.Stop();
    }
    public void ArrowClicked(int i)
    {
        cam = GameObject.Find("Main Camera");
        if (i == 0 || i == 2)
        {
            image = GameObject.Find("Bg1");
        }
        else if (i == 1 || i == 4)
        {
            image = GameObject.Find("Bg2");
        }
        else if (i == 3 || i == 6)
        {
            image = GameObject.Find("Bg3");
        }
        else if (i == 5)
        {
            image = GameObject.Find("Bg4");
        }

        cam.transform.position = new Vector3(image.transform.position.x, image.transform.position.y, -10);
    }

    public void ObjectClicked(int i)
    {
        cam = GameObject.Find("Main Camera");
        if (i == 0)
        {
            image = GameObject.Find("SceneShed");
        }
        else if (i == 1)
        {
            image = GameObject.Find("Bg1");
        }
        else if (i == 2)
        {
            image = GameObject.Find("SceneContainer");
        }
        else if (i == 3)
        {
            image = GameObject.Find("Bg2");
        }
        else if (i == 4)
        {
            image = GameObject.Find("SceneNeighbour");
            Neighbour.simonPlaying = true;
            Neighbour neighbour = new Neighbour();
            neighbour.SimonStart();
        }
        else if (i == 5)
        {
            image = GameObject.Find("Bg4");
            Neighbour.simonPlaying = false;
        }
        else if (i == 6)
        {
            image = GameObject.Find("SceneDoor");
        }
        else if (i == 7)
        {
            image = GameObject.Find("Bg4");
        }

        cam.transform.position = new Vector3(image.transform.position.x, image.transform.position.y, -10);
    }
}
