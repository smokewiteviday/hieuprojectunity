using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    bool isOpened = false;
    void OnTriggerEnter(Collider col)
    {
        if(isOpened == false)
        {
           
                isOpened = true;
                door.transform.position += new Vector3(0, 1, 0);
            
        }
    }
}
