using UnityEngine;
using System.Collections;

public class MainMenuButtons : MonoBehaviour {

	public void Play(){
		Application.LoadLevel ("Levels");
}

	public void Quit(){
//		Application.Quit;

	}
}
