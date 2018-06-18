using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cesto2 : MonoBehaviour {

	private void OnTriggerEnter(Collider col)
	{
		col.GetComponent<Jogar>().VoltaPosicao();

	}
}
