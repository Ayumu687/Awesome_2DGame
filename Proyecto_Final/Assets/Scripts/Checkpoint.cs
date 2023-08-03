using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
	public GameObject activeCP;		//Checkpoint activo
	public GameObject inactiveCP;	//Checkpoint no activo
	AudioSource sound;

	void Start()
	{
		sound = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		PlayerMove.newX = gameObject.transform.position.x;
		PlayerMove.newY = gameObject.transform.position.y;
		inactiveCP.SetActive(false);
		activeCP.SetActive(true);
		sound.Play();
	}
}