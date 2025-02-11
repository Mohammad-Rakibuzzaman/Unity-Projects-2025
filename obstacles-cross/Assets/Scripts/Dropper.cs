using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 3.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(Time.time);
        if (Time.time > timeToWait) 
        {
            Debug.Log("Lookout below!");
        }
    }
}
