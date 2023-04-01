using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordManager : MonoBehaviour {

	public List<Word> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;

	public audio Aud;

	public int wordsFallen;
	public static int wordsFallenPref = 0;

	public int charsTyped;
	public static int charsTypedPref = 0;

	public Text wordsFallenT;
	public Text charsTypedT;




	public int wordsCorrect;
	public static int wordsCorrectPref = 0;

	public float percentCorrect;
	public static float percentCorrectPref = 0;

	public Text wordsCorrectT;
	public Text percentCorrectT;


	void Update () 
	{
		wordsFallenT.text = wordsFallen.ToString();
		charsTypedT.text = charsTyped.ToString();
	}

	public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);

		wordsFallen = wordsFallen + 1;
		PlayerPrefs.SetInt("WordsFallenPref", wordsFallen);
        wordsFallenPref = PlayerPrefs.GetInt("WordsFallenPref");
        PlayerPrefs.Save();
		
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
				Aud.playSound();

				charsTyped = charsTyped + 1;
				PlayerPrefs.SetInt("CharsTypedPref", charsTyped);
        		charsTypedPref = PlayerPrefs.GetInt("CharsTypedPref");
        		PlayerPrefs.Save();
			}
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					Aud.playSound();

					charsTyped = charsTyped + 1;
					PlayerPrefs.SetInt("CharsTypedPref", charsTyped);
        			charsTypedPref = PlayerPrefs.GetInt("CharsTypedPref");
        			PlayerPrefs.Save();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);

			wordsCorrect = wordsCorrect + 1;
			PlayerPrefs.SetInt("WordsCorrectPref", wordsCorrect);
			wordsCorrectPref = PlayerPrefs.GetInt("WordsCorrectPref");
			PlayerPrefs.Save();
			Debug.Log("wordscorrect: " + wordsCorrect);


			// everything but percent is working!!
			percentCorrect = Mathf.Round(wordsCorrect) / Mathf.Round(wordsFallen) * 100;
			
			PlayerPrefs.SetFloat("PercentCorrectPref", percentCorrect);
			percentCorrectPref = PlayerPrefs.GetFloat("PercentCorrectPref");
			PlayerPrefs.Save();
			Debug.Log("percentCorrect: " + percentCorrectPref);
		}
	}

}
