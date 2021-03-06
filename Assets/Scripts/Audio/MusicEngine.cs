﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class TransitionAndName {
	public string name;
	public MusicTransition transition;
}

public class MusicEngine : MonoBehaviour {

	public AudioMixerSnapshot paused;
	public AudioMixerSnapshot currentMusicSnapshot;
	public AudioMixerSnapshot[] mixerSnapshots;
	
	public float pauseTransitionTime;
	public TransitionAndName[] events;

	void Start (){
		currentMusicSnapshot = mixerSnapshots[1];
		currentMusicSnapshot.TransitionTo(3f);
	}
    
	public void ChangeMusicWithName(string name) {
		var playedSound = false;
		foreach (var eventAndName in events) {
			if (eventAndName.name == name && eventAndName.transition) {
				eventAndName.transition.ChangeMusic();
				playedSound = true;
			}
		}

		// Debugging thing
		if (!playedSound) {
			Debug.LogError("Couldn't find sound for name: " + name);
		}
	}

	public void PauseMusic(){
		if (!mixerSnapshots[0]){
			Debug.LogWarning("PauseMusic Snapshot missing. Its going to be ok.");
		}else{
			mixerSnapshots[0].TransitionTo(pauseTransitionTime);
		}
	}

	public void UnpauseMusic(){
		currentMusicSnapshot.TransitionTo(pauseTransitionTime);
		
	}



}
