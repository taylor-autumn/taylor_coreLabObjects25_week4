using NUnit.Framework;
using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class ominousMessage : MonoBehaviour
{

    public TMP_Text messageText;
    public List<string> ominousMessages;
    //public string displayedMsg;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scaryMessages()
    {
        //option 1 below
        //displayedMsg = ominousMessages[Random.Range(0,ominousMessages.Count)];
        ////count for list, length for arrays
        //messageText.text = displayedMsg;
        messageText.text=ominousMessages[Random.Range(0,ominousMessages.Count)];

    }


}
