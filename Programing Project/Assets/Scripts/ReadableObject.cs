using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadableObject : MonoBehaviour
{
    public Text InfoText;

    public GameObject InfoButton;

    public string newInfo;

    public void GiveInfo(string newInfo) //Function to Bring up info button & text
    {
        InfoButton.SetActive(true);
        InfoText.text = newInfo;
    } 
    
    public void TakeInfo() //Function to take away info button & text
    {
        InfoButton.SetActive(false);
        InfoText.text = "";
    }

    public bool Readable = true;
   
    
}
