using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //OnCollisionEnter is a callback method or function that is called when the object collides with another object
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
        Debug.Log("You hit something!");
    }




}
