using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTarget : MonoBehaviour
{
	private Rigidbody enemyRb;
	private float speed = 1f;
    private GameObject player;
	private bool targeting = true;

	public bool easyBall = false;
	public bool mediumBall = false;
	public bool hardBall = false;

	void Start()
    {
		enemyRb = GetComponent<Rigidbody>();
		player = GameObject.Find("Player");

		if (easyBall) 
		{
			speed *= 0.7f;
		}
		if (mediumBall)
		{
			speed *= 2.1f;
		}
		if (hardBall)
		{
			speed *= 3.5f;
		}
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 midPoint = (player.transform.position - transform.position) / 2;

		if (midPoint.magnitude >= 2.5f && targeting)
		{
			enemyRb.AddForce(midPoint.normalized * speed);
		}
		else if (midPoint.magnitude < 2.5f)
		{
			targeting = false;
			Destroy(gameObject, 3);
		}

    }
}
