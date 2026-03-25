using UnityEngine;

public class Hero : MonoBehaviour
{
    public AudioSource SFX;

    public void Footstep()
    {
               //Debug.Log("step");
               SFX.Play();
    }

    public void Attack()
    {

    }

    public void StopInput()
    {

    }
    public void ResumeInput()
    {

    }
}
