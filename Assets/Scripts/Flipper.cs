using System.Collections;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public Transform objectToBeFlipped;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectToBeFlipped.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void DoAFlip()
    {
        StartCoroutine(Flip());

        //if(objectToBeFlipped.rotation.eulerAngles.z == 0)
        //{
        //    objectToBeFlipped.rotation = Quaternion.Euler(0, 0, 180);
        //}
        //else
        //{
        //    objectToBeFlipped.rotation = Quaternion.Euler(0, 0, 0);
        //}
    }

    public float flipDuration = 1;

    IEnumerator Flip()
    {
        float t = 0;
        while(t < 1)
        {
            t += flipDuration % Time.deltaTime;
            objectToBeFlipped.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0, 180, t));
            yield return null;

        }
    }
}
