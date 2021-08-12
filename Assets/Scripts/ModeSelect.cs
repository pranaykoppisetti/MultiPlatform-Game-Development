using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int RaceMode;

    //Race mode selection and assigning numbers based on which mode would get selected on clicking it
    public void ScoreMode()
    {
        RaceMode = 1;
    }

    public void TimeMode()
    {
        RaceMode = 2;
    }

    public void RacingMode()
    {
        RaceMode = 0;
    }
}
