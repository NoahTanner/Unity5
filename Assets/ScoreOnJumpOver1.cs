using UnityEngine;

public class ScoreWhenJumpOver1 : MonoBehaviour
{
    public int score = 0; // Initialize score

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the trigger is with an object on the "Head" layer
        if (other.gameObject.layer == LayerMask.NameToLayer("Head"))
        {
            // Optional: Check if the trigger object's parent is tagged as "TargetPlayer" to ensure it's a valid target
            if (other.transform.parent.CompareTag("Player2")) // Assuming the head's parent has the tag
            {
                // Increment score
                score++;
                Debug.Log(gameObject.name + " Score: " + score);

                // Optional: Notify some ScoreManager or game controller to update UI or other game elements
            }
        }
    }
}
