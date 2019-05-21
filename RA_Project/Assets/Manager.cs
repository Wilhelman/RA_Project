using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private int goalkeeper_points = 0;
    private int shooter_points = 0;

    public Text textGoals;
    public Text textStopped;

    public void UpdateGoals()
    {
        shooter_points++;
        textGoals.text += shooter_points.ToString();
    }

    public void UpdateStopped()
    {
        goalkeeper_points++;
        textStopped.text += goalkeeper_points.ToString();
    }
}
