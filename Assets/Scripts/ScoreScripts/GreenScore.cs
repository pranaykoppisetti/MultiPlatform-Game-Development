using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenScore : MonoBehaviour
{
    void OnTriggerEnter()
    {
        ModeScore.CurrentScore += 10;//+10 woould be added to the score on collecting the green collectible
        gameObject.SetActive(false);// It will diappear for collection
    }
}
