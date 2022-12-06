using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
  public int currentScore = 0;
 public void UpdateScore(int scoreToAdd)
    {
        Debug.Log("Reading scoreToAdd as " + scoreToAdd);
        currentScore = currentScore + scoreToAdd;
        Debug.Log("Reading current score as " + currentScore);
    }
}
