﻿using UnityEngine;
using System.Collections;

public class VizCircles : MonoBehaviour {


	public GameObject spriteCircle;

	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void VizNote(Message message)
	{
		GameObject[] myCircles = GameObject.FindGameObjectsWithTag("viz");
		if (myCircles.Length > 0 && Random.Range (0, 10) < 7)
		{
			int index = Random.Range (0, myCircles.Length - 1);
			float tempScale = Random.Range (0.8f, 1.0f);
			myCircles[index].transform.localScale = new Vector3 (tempScale, tempScale, tempScale);
			if(message.Instrument == InstrumentType.Drum)
				myCircles[index].GetComponent<SpriteRenderer> ().material.color = new Color (217.0f/255.0f, 94.0f/255.0f, 64.0f/255.0f, 1);
			else if(message.Instrument == InstrumentType.Piano)
				myCircles[index].GetComponent<SpriteRenderer> ().material.color = new Color (86.0f/255.0f, 113.0f/255.0f, 133.0f/255.0f, 1);
			else if(message.Instrument == InstrumentType.SoundEffects)
				myCircles[index].GetComponent<SpriteRenderer> ().material.color = new Color (217.0f/255.0f, 94.0f/255.0f, 64.0f/255.0f, 1);
			else
				myCircles[index].GetComponent<SpriteRenderer> ().material.color = new Color (1, 1, 1, 1);
				
		} 
		else
		{
			GameObject myObj = Instantiate (spriteCircle, new Vector3 (Random.Range (-8.0f, 8.0f), Random.Range (-4.0f, 4.0f), 0), Quaternion.identity) as GameObject;
			float tempScale = Random.Range (0.5f, 1.0f);
			myObj.transform.localScale = new Vector3 (tempScale, tempScale, tempScale);
			if(message.Instrument == InstrumentType.Drum)
				myObj.GetComponent<SpriteRenderer> ().material.color = new Color (217.0f/255.0f, 94.0f/255.0f, 64.0f/255.0f, 1);
			else if(message.Instrument == InstrumentType.Piano)
				myObj.GetComponent<SpriteRenderer> ().material.color = new Color (86.0f/255.0f, 113.0f/255.0f, 133.0f/255.0f, 1);
			else if(message.Instrument == InstrumentType.SoundEffects)
				myObj.GetComponent<SpriteRenderer> ().material.color = new Color (217.0f/255.0f, 94.0f/255.0f, 64.0f/255.0f, 1);
			else
				myObj.GetComponent<SpriteRenderer> ().material.color = new Color (1, 1, 1, 1);

		}
	}
}
