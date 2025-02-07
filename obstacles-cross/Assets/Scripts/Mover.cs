using UnityEngine;

public class Mover : MonoBehaviour
{




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Translate method made by unity clever fox
        
    }

    // Update is called once per frame
    void Update()
    {

        
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue, yValue, zValue);
        
    }
}
