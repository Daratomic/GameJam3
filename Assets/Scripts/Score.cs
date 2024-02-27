using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    private int curScore;
    
    [SerializeField]
    private int defaultAddVal;
    [SerializeField]
    private int multiplier;

    [SerializeField]
    private TMP_Text text;

    public void AddScore(int matches)
    {
        int multi = multiplier * matches;
        curScore += (defaultAddVal * multi);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        text.SetText(curScore.ToString());

    }
}
