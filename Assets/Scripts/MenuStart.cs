using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour {

	public void ChangeMenuScene(string SceneName){
		Application.LoadLevel(SceneName);
	}
}
