using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class Exit : MonoBehaviour
{
    
	public Text wordsFallenT;
	public Text charsTypedT;
	public Text wordsCorrectT;
	public Text percentCorrectT;
    

    public void Start()
    {
        // gameObject.GetComponent<writeScores>().AddNewScore();
        // gameObject.GetComponent<readScores>().ShowTopScores();

        // int newhighscore;
        // newhighscore = Score.highScorePref;
        // showHighScore.text = newhighscore.ToString();

        int newWordsFallen;
        newWordsFallen = WordManager.wordsFallenPref;
        wordsFallenT.text = newWordsFallen.ToString();

        int newCharsTyped;
        newCharsTyped = WordManager.charsTypedPref;
        charsTypedT.text = newCharsTyped.ToString();

        int newWordsCorrect;
        newWordsCorrect = WordManager.wordsCorrectPref;
        wordsCorrectT.text = newWordsCorrect.ToString();

        float newPercentCorrect;
        newPercentCorrect = WordManager.percentCorrectPref;
        percentCorrectT.text = newPercentCorrect.ToString("F2") + "%";
    }

}
