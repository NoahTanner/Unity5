using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed = 5.0f; // Speed of the character
    public float rotationSpeed = 100.0f;

    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float rotation = 0f;
        float moveVertical = 0f;

        // Check if A or D is pressed for horizontal movement
        if (Input.GetKey(KeyCode.J))
        {
            rotation = -1f;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            rotation = 1f;
        }

        // Check if W is pressed for forward movement
        if (Input.GetKey(KeyCode.I))
        {
            moveVertical = 1f;
        }

        transform.Rotate(0, rotation * rotationSpeed * Time.deltaTime, 0);

        Vector3 movement = transform.forward * moveVertical * speed * Time.deltaTime;

        // Normalize the movement vector to ensure consistent speed in all directions
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the character
        transform.Translate(movement, Space.World);
    }
}

