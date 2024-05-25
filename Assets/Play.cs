using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public string Level;
    public AudioSource AudioSource;
    private void OnMouseDown()
    {

        transform.position -= new Vector3(0, 0.1f, 0);
        AudioSource.Play();
    }
    private void OnMouseUp()
    {

        transform.position += new Vector3(0, 0.1f, 0);
        SceneManager.LoadScene(Level);
        



    }
}
