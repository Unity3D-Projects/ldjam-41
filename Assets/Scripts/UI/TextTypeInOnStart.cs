﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTypeInOnStart : MonoBehaviour {



	private UnityEngine.UI.Text text;
	private string fullTextStr;
	public float typeSpeed;
	public float typeDelay;

	private float typeTimer = 0;
	private bool delayPassed = false;
	private SoundEngine soundEngine;
	public string sound;

	// Use this for initialization
	void Start () {
		text = GetComponent<UnityEngine.UI.Text>();
		fullTextStr = text.text;
		text.text = "";
		soundEngine = Object.FindObjectOfType<SoundEngine>();
	}
	
	// Update is called once per frame
	void Update () {
		// Do nothing if the string is empty
		if(fullTextStr.Length == 0)
			return;

		// Don't start typing unless we've passed the delay time
		typeTimer += Time.deltaTime;
		if(!delayPassed) {
			if(typeTimer >= typeDelay) {
				delayPassed = true;
				typeTimer -= typeDelay;
			}
		} else {
			if(typeTimer >= typeSpeed) {
				typeTimer -= typeSpeed;
				text.text += fullTextStr[0];
				if (fullTextStr[0] == ' ') {
					//Debug.Log("Print [space]");
				/*}else if(fullTextStr[0] == '|'){
					soundEngine.PlaySoundWithName("Dash");*/
				}else{
					//Debug.Log("printing [" + fullTextStr[0] + "]");
					soundEngine.PlaySoundWithName(sound);
				}
				fullTextStr = fullTextStr.Substring(1);
				if(fullTextStr.Length == 0) {
					BroadcastMessage("OnTypingAnimationCompleted",SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}
