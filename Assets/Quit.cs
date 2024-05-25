using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public AudioSource AudioSource;
    private void OnMouseDown()
    {

        transform.position -= new Vector3(0, 0.1f, 0);
        AudioSource.Play();
    }
    private void OnMouseUp()
    {

        transform.position += new Vector3(0, 0.1f, 0);
        Application.Quit();



    }
}
