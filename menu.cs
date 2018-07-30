using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

	public void StartFirstLevel(){
		SceneManager.LoadScene(1);
	}
	/*public void Starttutorial(){
		SceneManager.LoadScene();
	}*/
	public void LoadMainMenu(){
		SceneManager.LoadScene(0);
	}

}
