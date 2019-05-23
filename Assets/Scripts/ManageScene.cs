using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageScene : MonoBehaviour {

	public int currLevel = 0;
	// Use this for initialization
	public string[] scenes = new string[2] { "Default", "Default2" };

	static ManageScene s = null;

	void Start () {
		if (s == null) {
			s = this;
		} else {
			Destroy (this.gameObject);
		}
		DontDestroyOnLoad (this.gameObject);
		this.gameObject.transform.position = new Vector3(0, 0, 0);
		this.gameObject.transform.rotation = Quaternion.identity;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			currLevel = (currLevel + 1) % 2;
			this.loadOtherScene ();
		}
	}

	public void loadOtherScene(){
		UnityEngine.SceneManagement.SceneManager.LoadSceneAsync (scenes [currLevel]);
	}
}
