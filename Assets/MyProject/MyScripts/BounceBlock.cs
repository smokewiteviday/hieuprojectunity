using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBlock : MonoBehaviour
{
    [Range(100, 10000)]
    public float bounce;
    private void OnCollisionEnter(Collision col)
    {
        GameObject bouncer = col.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * bounce);
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime * 50);
    }

}
