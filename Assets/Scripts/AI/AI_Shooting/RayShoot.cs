using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class RayShoot : MonoBehaviour
{
	public Transform firePoint;
	public Transform rocket;
	public LineRenderer lineRendererAim;
	public LineRenderer lineRendererShoot;
	public float timer;
	public float time;
	private bool inTrigger = false;
	private bool timerOn = false;
	public GameObject targetLocation;
	


	public int damage = 1;

	void Start()
	{
		time = timer;
	}
	void Update()
	{

		// Debug.Log("The distance is " + (rocket.transform.position - transform.position).magnitude);
		float distance = (rocket.transform.position - transform.position).magnitude;
		// RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, (rocket.transform.position - firePoint.position));

		Debug.DrawRay(start: firePoint.position, dir: (rocket.transform.position - firePoint.position), color: Color.yellow);
		if (timerOn == false)
		{
			timer -= Time.deltaTime;
		}

		if (distance <= 25f)
		{
			if (timer <= 0f)
			{
				StartCoroutine(Shoot());
				timer = time;
			}
		}
	}

	IEnumerator Shoot ()
	{
		
		var player = GameObject.FindGameObjectWithTag("Player").transform.position;
		// Vector2 locDirection = new Vector2(player.x - transform.position.x, player.y - transform.position.y );
		Vector2 locDirection = new Vector2(player.x - transform.position.x, player.y - transform.position.y );

		Debug.DrawRay(firePoint.position, locDirection * 100, Color.green );

		timerOn = false;


		GameObject clone;
		clone = Instantiate(targetLocation, locDirection , transform.rotation);

		Debug.Log(targetLocation.transform.position);

		lineRendererAim.SetPosition(0, firePoint.transform.position);
		lineRendererAim.SetPosition(1, clone.transform.position);

		lineRendererAim.enabled = true;

		this.gameObject.GetComponent<AIPath>().enabled = false;

		yield return new WaitForSeconds(4f);


		lineRendererAim.enabled = false;

		lineRendererShoot.SetPosition(0, firePoint.position);
		lineRendererShoot.SetPosition(1, clone.transform.position);

		lineRendererShoot.enabled = true;

		
			RaycastHit2D hit = Physics2D.Raycast(firePoint.position, locDirection);
			Debug.DrawRay(firePoint.position, locDirection * 100 , Color.red);

			if(hit)
			{
				Debug.Log(hit.transform.name);
				var pHP = hit.transform.GetComponent<PlayerHealth>();

				if(pHP !=null)
				{
					pHP.TakeDamage(damage);
					
				}
			}

			


		yield return new WaitForSeconds(4f);


		DestroyImmediate(targetLocation);

		lineRendererShoot.enabled = false;

		this.gameObject.GetComponent<AIPath>().enabled = true;

		timerOn = true;
	}
}
