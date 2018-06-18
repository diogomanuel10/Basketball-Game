using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caixa : MonoBehaviour {

	private void OnTriggerEnter(Collider col)
	{
		col.GetComponent<Jogar>().VoltaPosicao();
		col.GetComponent<Jogar>().DiminuiVidas();
	}
}
