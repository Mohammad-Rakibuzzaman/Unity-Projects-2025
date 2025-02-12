using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 10f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This is called caching a reference to the MeshRenderer component
        myMeshRenderer = GetComponent<MeshRenderer>();
        // GetComponent<MeshRenderer>().enabled = false;
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }
 
    // Update is called once per frame
    void Update()
    {

        // Debug.Log(Time.time);
        if (Time.time > timeToWait) 
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
            // Debug.Log("Lookout below!");
        }
    }
}
