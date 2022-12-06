using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float strength;
    public Vector3 direction;
    public AudioClip windSound;
    private void Update()
    {
        AudioSource.PlayClipAtPoint(windSound, this.transform.position);
    }
    
    
   
}
