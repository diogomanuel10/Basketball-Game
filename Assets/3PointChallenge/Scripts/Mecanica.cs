using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanica : MonoBehaviour {
	private float ToqueI;
	private float ToqueF;
	private Vector3 PosicaoToqueI;
	private Vector3 PosicaoToqueF;

	private float ForcaXaxis; //velocidade no eixo do x
	private float ForcaYaxis; //velocidade no eixo do y
	private float ForcaZaxis; //velocidade no eixo do z

	private Vector3 RequireForce;

	public Rigidbody Ball;
	public Rigidbody Ball2;


	public bool canswipe = true;

	void Start()
	{
		Time.timeScale = 3; //aumenta a velocidade em 3 vezes
		Ball.useGravity = false;

	}

	public void PressionaRato() //quando rato está pressionado
	{
		if (canswipe = true) {
			ToqueI = Time.time;
			PosicaoToqueI = Input.mousePosition;
		}
	}

	public void SoltaRato() //quando solta o rato ou o toque
	{
		if (canswipe = true) {
			ToqueF = Time.time;
			PosicaoToqueF = Input.mousePosition;
			Lanca ();
		}
	}

	public void Lanca(){

		ForcaXaxis = ToqueF - ToqueI;
		ForcaYaxis = PosicaoToqueF.y - PosicaoToqueI.y;
		ForcaZaxis = PosicaoToqueF.z - PosicaoToqueI.z;

		RequireForce = new Vector3 (-ForcaXaxis * 155f, ForcaYaxis/3.2f, ForcaZaxis);
		Ball.useGravity = true;
		Ball.velocity = RequireForce;
		if (Ball.useGravity = true) {
			Ball2.useGravity = false;
		} else if (Ball.useGravity = false) {
			Ball2.useGravity = true;
		}
		canswipe = false;
	}

}

