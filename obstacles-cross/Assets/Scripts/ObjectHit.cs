using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //OnCollisionEnter is a callback method or function that is called when the object collides with another object
    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            gameObject.tag = "Hit";
        }
        
        // Debug.Log("You hit something!");
    }

}
