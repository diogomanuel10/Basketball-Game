using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

	public void Out(){
		Application.Quit ();

	}

	public void Voltar(){
		SceneManager.LoadScene ("jogo");
	}
}
