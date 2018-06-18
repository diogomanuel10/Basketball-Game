using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancamento : MonoBehaviour {
	private float ToqueI;
	private float ToqueF;
	private Vector2 PosicaoToqueI;
	private Vector2 PosicaoToqueF;

	private float ForcaXaxis; //velocidade no eixo do x
	private float ForcaYaxis; //velocidade no eixo do y
	private float ForcaZaxis; //velocidade no eixo do z

	private Vector3 RequireForce;

	public Rigidbody Ball;

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
		
		ForcaXaxis = PosicaoToqueF.x - PosicaoToqueI.x;
		ForcaYaxis = PosicaoToqueF.y - PosicaoToqueI.y;
		ForcaZaxis = ToqueF - ToqueI;

		RequireForce = new Vector3 (-ForcaXaxis, ForcaYaxis/2f, -ForcaZaxis * 150f);
		Ball.useGravity = true;
		Ball.velocity = RequireForce;

		Ball.isKinematic = false;

		canswipe = false;
		}

}
