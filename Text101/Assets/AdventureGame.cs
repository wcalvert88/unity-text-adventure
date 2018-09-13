using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;

	// Use this for initialization
	void Start () {
        textComponent.text = ("Welcome to my first text adventure game!");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
