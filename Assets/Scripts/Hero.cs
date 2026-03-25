using UnityEngine;
using UnityEngine.InputSystem;

public class Hero : MonoBehaviour
{
    public Animator animator;
    public AudioSource footstep;
    public AudioSource impact;
    public bool canInput = true;
    public float speed = 5;
    public Vector2 movement;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if(canInput)
        {
            transform.position += (Vector3)movement * speed * Time.deltaTime;

            
        }

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetBool("isMoving", true);
        } else
        {
            animator.SetBool("isMoving", false);
        }

        //transform.position = mouseMovement;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void Footstep()
    {
               //Debug.Log("step");
               footstep.Play();
    }

    public void AttackStart()
    {
        StopInput();
    }

    public void AttackHit()
    {
        //Debug.Log("hit");
        impact.Play();
    }

    public void AttackEnd()
    {
        ResumeInput();
    }

    public void StopInput()
    {
        canInput = false;
    }
    public void ResumeInput()
    {
        canInput = true;
    }

    public void RollStart()
    {
        StopInput();
    }

    public void RollEnd()
    {
        ResumeInput();
    }


}
