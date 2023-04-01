using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerName : MonoBehaviour
{
    public InputField PlayerNameInput;
    public Text showPlayerName;
    public static string PlayerName;

    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text; 
    }

    public void ShowName()
    {
        showPlayerName.text = PlayerName;
    }
}
