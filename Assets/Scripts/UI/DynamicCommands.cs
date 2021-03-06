﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using UnityEngine.UI;

//Prints Current Available Commands as Text
public class DynamicCommands : MonoBehaviour
{
    public IEnumerable<Cradle.StoryLink> links;
    public TextrisTwinePlayer twinePlayer;
    public Cradle.StoryVar items;
    public Text commandText;

    private string fullTextStr = "";
    private bool shouldUpdateCommands = false;

    // Use this for initialization
    void Start()
    {
        twinePlayer = Object.FindObjectOfType<TextrisTwinePlayer>();
        links = twinePlayer.Story.GetCurrentLinks();
        items = twinePlayer.Story.Vars["inv"];
    }
    
    // Update is called once per frame
    void Update()
    {
        UpdateText();     
    }

    void UpdateText() {
        var newStr = "CMD:/\n";
        newStr += PrintCommands();
		newStr += "\n\nINV:/\n";
        newStr += PrintInv();
        if(!shouldUpdateCommands && !GetComponent<TextTypeInOnStart>().enabled) {
            // HACK: Attach a typing effect after determining what the commands should be
            commandText.text = newStr;
            GetComponent<TextTypeInOnStart>().enabled = true;
        }
        if(newStr != fullTextStr && shouldUpdateCommands) {
            commandText.text = newStr;
            fullTextStr = commandText.text;
        }
    }

    string PrintCommands()
    {
        var str = "";
        links = twinePlayer.Story.GetCurrentLinks();
        foreach (var link in links)
        {
            var text = link.Text;

            //Longer commands like "GET COAT" do not enter TETRIS space
            if (text.Contains(" "))
            {
                string[] words = text.Split(null);
                str += "\n" + words[0];
                str += "\n" + words[1];
            }
            else
            {
                str += "\n" + text;
            }
        }
        return str;
    }

    string PrintInv()
    {
        var str = "";
        items = twinePlayer.Story.Vars["inv"];

        if (items["NOTE"] == true)
        {
            str += "\nNOTE";
        }
        if (items["COAT"] == true)
        {
            str += "\nCOAT";
        }
        if (items["GUN"] == true)
        {
            str += "\nGUN";
        }
        if (items["FOB"] == true)
        {
            str += "\nFOB";
        }
        if (items["CURE"] == true)
        {
            str += "\nCURE";
        }

        return str;
    }

    void OnTypingAnimationCompleted() {
        shouldUpdateCommands = true;
    }
}
