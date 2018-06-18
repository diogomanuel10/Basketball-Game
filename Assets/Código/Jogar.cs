using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogar : MonoBehaviour {

	public Text score;
	public Text vidas;
	public int Resultado = 0;
	public int vidas_numero = 3;
	private Vector3 PosicaoI;
	private Lancamento SistemaLancamento;
	public AudioSource audios;
	public Text highscoreText;
	int highscore;




	void start(){
		SistemaLancamento = GameObject.FindObjectOfType<Lancamento>().GetComponent<Lancamento>();
		PosicaoI = this.transform.position; //define a posição inicial
		audios.GetComponent<AudioSource>();
		highscore = PlayerPrefs.GetInt ("HighScore", Resultado);
		highscoreText.text = "High Score: " + highscore;

		MudaTexto();
	}
		
	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ring") {
			
			AtualizaResultado ();
			audios.Play ();
			//vidas_numero++;
		}
		if (vidas_numero == 0) {
			SceneManager.LoadScene ("gameover");
			PlayerPrefs.Save ();
		}
	}

	public void DiminuiVidas(){

		vidas_numero--;
		MudaTexto ();


	}



	public void MudaTexto()
	{
		vidas.text = "Bolas Restantes:" + vidas_numero.ToString ();
	}

	public void AtualizaResultado(){

		Resultado++;
		score.text = "Pontuação: " + Resultado.ToString();
		highscoreText.text = "High Score: " + highscore;


	}

	public void VoltaPosicao()
	{
		this.transform.position = new Vector3(-5.4f,76.86f,Random.Range(250f,400f));
		this.GetComponent<Rigidbody> ().useGravity = false;
		this.GetComponent<Rigidbody> ().isKinematic = true;
		this.GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}

}
