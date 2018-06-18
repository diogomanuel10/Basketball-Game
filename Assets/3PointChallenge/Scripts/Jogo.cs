using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jogo : MonoBehaviour {

	public Text score;
	private int Resultado = 0;
	private Vector3 PosicaoI;
	private Mecanica SistemaLancamento;

	void start(){
		SistemaLancamento = GameObject.FindObjectOfType<Mecanica>().GetComponent<Mecanica>();
		PosicaoI = this.transform.position; //define a posição inicial
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Ring")
		{
			AtualizaResultado();
		}
	}

	private void AtualizaResultado(){

		Resultado++;
		score.text = "Pontos: " + Resultado.ToString();

	}
}
