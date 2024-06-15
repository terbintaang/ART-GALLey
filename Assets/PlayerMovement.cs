using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Update()
    {
        // Mengambil input dari W/A/S/D dan Arrow Keys
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Mengambil input dari Arrow Keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveVertical += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveVertical -= 1;
        }

        // Jika tidak ada input, set movement ke zero dan matikan animator
        if (moveHorizontal == 0 && moveVertical == 0)
        {
            movement = Vector2.zero;
            animator.enabled = false; // Mematikan animator
        }
        else
        {
            // Menghitung arah gerakan
            movement = new Vector2(moveHorizontal, moveVertical).normalized;
            animator.enabled = true; // Menghidupkan animator
        }

        // Update animator parameters jika animator aktif
        if (animator.enabled)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
    }

    void FixedUpdate()
    {
        // Memindahkan pemain
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
