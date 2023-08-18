using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gg : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
	public void changeScene(string SceneName){
		SceneManager.LoadScene(SceneName,LoadSceneMode.Single);
	}
}
