using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 50f; 

    void Update()
    {
        
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }
}
