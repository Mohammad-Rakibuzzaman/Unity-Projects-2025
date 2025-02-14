using UnityEngine;

public class Mover : MonoBehaviour
{



   
    [SerializeField] float moveSpeed = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        PrintInstruction();
        
    }

    // Update is called once per frame
    void Update()
    {
         
        MovePlayer();
       
    }

    void PrintInstruction()
    {
        Debug.Log("You are welcome to our game!");
        Debug.Log("Move using wasd or arrow keys.");
        Debug.Log("Don't hit the walls!");
        
    }



    void MovePlayer() 
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //-1 pushing left, 1 pushing right, 0 is nothing 
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
    


}


// documents

// so in the obstacle lesson learned that z value for forward and backward, x value for left and right, and y value for up and down
