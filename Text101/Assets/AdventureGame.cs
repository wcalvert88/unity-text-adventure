using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;

	// Use this for initialization
	void Start () {
        textComponent.text = ("You wake up in a room and don't remember where you are " +
                                "or how you got there.  It smells alright and it looks " +
                                "like there is a beer on the table.\n\nWhat should I do?\n" +
                                "Press D to wait and drink the beer or press S to snag the " + 
                                "beer and get out of here. ");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
