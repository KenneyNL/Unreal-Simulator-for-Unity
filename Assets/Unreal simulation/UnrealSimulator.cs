using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class UnrealSimulator : MonoBehaviour{
	
	[SerializeField] private int numberObjects = 4;
	[SerializeField] private bool showSuppress = true;
	
	[SerializeField] private Text textRebuilt;
	[SerializeField] private Text textSuppress;
	
	void Awake(){
		
		if(!showSuppress){ textSuppress.text = ""; }
		textRebuilt.text = string.Format(textRebuilt.text, numberObjects);
		
	}
	
}
