using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump2 : MonoBehaviour
{
    public float jumpForce = 7f; // The force added when the object jumps
    private Rigidbody rb; // Reference to the Rigidbody component
    public LayerMask groundLayers; // Layer mask to determine what is considered ground for the object
    public Transform groundCheck; // A transform positioned where the ground check should happen
    public float groundCheckRadius = 0.5f; // Radius of the ground check sphere

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get and store a reference to the Rigidbody component
    }

    void Update()
    {
        // Check if the jump key (Space) is pressed and the object is grounded
        if (Input.GetKeyDown("k") && IsGrounded())
        {
            Jump();
        }
    }

    bool IsGrounded()
    {
        // Perform a sphere check at the groundCheck position, within groundCheckRadius, against groundLayers
        return Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayers, QueryTriggerInteraction.Ignore);
    }

    void Jump()
    {
        // Add an upward force to the Rigidbody to make the object jump
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
