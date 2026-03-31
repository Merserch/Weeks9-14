using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed = 5;
    public Vector2 movement;
    public Vector2 rotation;
    public Vector2 mouseMovement;
    public AudioSource SFX;
    
    private void Update()
    {
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        
        transform.rotation = Quaternion.Euler(0, 0, (rotation.y * 90) + (rotation.x * -180) );
        //transform.position = mouseMovement;

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
        mouseMovement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
        
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        //same as Mouse.current.position.ReadValue()
        //rotation = context.ReadValue<Vector2>();
    }
}
