using UnityEngine;

public class HunterMovement : MonoBehaviour
{
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsWalking", false);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("IsWalking", true);
            Vector2 position = transform.position;
            position.x = position.x + 0.1f * horizontal;
            transform.position = position;
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
}
