using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Word {

	public string word;
	private int typeIndex;

	WordDisplay display;


	// public int wordsCorrect;
	// public static int wordsCorrectPref = 0;

	// public float percentCorrect;
	// public static float percentCorrectPref = 0;

	// // public int totalWords2;



	// public Text wordsCorrectT;
	// public Text percentCorrectT;

	public Word (string _word, WordDisplay _display)
	{
		word = _word;
		typeIndex = 0;

		display = _display;
		display.SetWord(word);
	}

	public char GetNextLetter ()
	{
		return word[typeIndex];
	}

	public void TypeLetter ()
	{
		typeIndex++;
		display.RemoveLetter();
	}

	public bool WordTyped ()
	{
		bool wordTyped = (typeIndex >= word.Length);
		if (wordTyped)
		{
			display.RemoveWord();

			// wordsCorrect = wordsCorrect + 1;
			// PlayerPrefs.SetInt("WordsCorrectPref", wordsCorrect);
			// wordsCorrectPref = PlayerPrefs.GetInt("WordsCorrectPref");
			// PlayerPrefs.Save();
			// Debug.Log("wordscorrect: " + wordsCorrect);


			// // totalWords2 = WordManager.totalWordsPref;
			// percentCorrect = wordsCorrect / WordManager.totalWordsPref;
			// PlayerPrefs.SetFloat("PercentCorrectPref", percentCorrect);
			// percentCorrectPref = PlayerPrefs.GetFloat("PercentCorrectPref");
			// PlayerPrefs.Save();
			// Debug.Log("percentCorrect: " + percentCorrect);
		}
		return wordTyped;


	}

}
