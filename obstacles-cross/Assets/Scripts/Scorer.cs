using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;
    private void OnCollisionEnter(Collision other) {
        // hits = hits + 1;
        if (other.gameObject.tag !=  "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
        // hits++;
        // Debug.Log("You've bumped into a thing this many times: " + hits);
    }
}
