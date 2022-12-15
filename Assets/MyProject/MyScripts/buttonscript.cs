using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonscript : MonoBehaviour
{
    public AudioClip gateOpen;
    [SerializeField]
    GameObject door;
    bool isOpened = false;
    void OnTriggerEnter(Collider col)
    {
        
        if (isOpened == false)
        {
           
            isOpened = true;
            door.transform.position += new Vector3(0, 3, 0);
            

        }
        
        AudioSource.PlayClipAtPoint(gateOpen, this.transform.position);
    }
}
