using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gantiScene : MonoBehaviour {
	
	[SerializeField] private string namaScene;

	void OnTriggerEnter(Collider col){
		
			SceneManager.LoadScene (namaScene);

	}
}
