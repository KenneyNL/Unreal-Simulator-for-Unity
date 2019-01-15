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
		
		textRebuilt.text = textRebuilt.text.Replace("%OBJECTS", numberObjects.ToString());
		
		if(!showSuppress){ textSuppress.text = ""; }
		
	}
	
}
