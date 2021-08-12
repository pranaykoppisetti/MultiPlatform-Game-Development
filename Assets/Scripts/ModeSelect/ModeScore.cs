using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour
{
    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreCollectibles;

    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;//By default race mode will be selected
        
        if(ModeSelection == 1)
        {
            RaceUI.SetActive(false);// Lap number and time would disappear on selecting score mode
            ScoreUI.SetActive(true);// score UI would be appearing on score mode selection
            AICar.SetActive(false);//AI car would disappear
            ScoreCollectibles.SetActive(true);//Collectibles would appear on the track
        }
    }

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;//score gets updated on collecting the collectibles
    }
}
