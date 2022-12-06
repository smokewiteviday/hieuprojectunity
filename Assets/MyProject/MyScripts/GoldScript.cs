using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    private GameObject objectHoldingTheScoreScript;
    private Score scoreScript;
    public AudioClip collectingGold;
    // Start is called before the first frame update
    void Start()
    {
        objectHoldingTheScoreScript = GameObject.Find("_ScoreManager");
        scoreScript = objectHoldingTheScoreScript.GetComponent<Score>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            scoreScript.UpdateScore(10);
            AudioSource.PlayClipAtPoint(collectingGold, this.transform.position);
            Destroy(gameObject);
        }
    }
}
