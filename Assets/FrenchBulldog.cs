using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrenchBulldog : MonoBehaviour
{
    public AudioSource woof;
    public void Woof()
    {
        woof.Play();
    }
}
