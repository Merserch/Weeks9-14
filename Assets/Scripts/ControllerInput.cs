using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed = 5;
    public Vector2 movement;
    public AudioSource SFX;
    
    private void Update()
    {
        //transform.position += (Vector3)movement * speed * Time.deltaTime;

        transform.position = movement;

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if(context.performed == true)
        {
            SFX.Play();
        }

    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        //same as Mouse.current.position.ReadValue()
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
        
    }
}
