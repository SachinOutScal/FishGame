﻿using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {

	[SerializeField] GlobalFlock globalFlock; 
	public float speed;
	public float maxSpeed =100; 	
	float neighborDistance = 3.0f;
	bool turning = false;

	// Use this for initialization
	void Start () {
		speed = Random.Range (0.5f, maxSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		ApplyTankBoundary ();

		if(turning) {
			Vector3 direction = Vector3.zero - transform.position;
			transform.rotation = Quaternion.Slerp (transform.rotation,
				Quaternion.LookRotation (direction),
				TurnSpeed () * Time.deltaTime);
			speed = Random.Range (0.5f, maxSpeed);
		} else {
			if (Random.Range (0, 5) < 1)
				ApplyRules ();
		}

		transform.Translate (0, 0, Time.deltaTime * speed);
	}

	void ApplyTankBoundary() {
		if(Vector3.Distance(transform.position, Vector3.zero) >= globalFlock.tankSize) {
			turning = true;
		} else {
			turning = false;
		}
	}

	void ApplyRules() {
		GameObject[] gos;
		gos = GlobalFlock.allFish;

		Vector3 vCenter = Vector3.zero;
		Vector3 vAvoid = Vector3.zero;
		float gSpeed = 0.1f;

		Vector3 goalPos = globalFlock.goalPos;

		float dist;
		int groupSize = 0;

		foreach (GameObject go in gos) {
			if (go != this.gameObject) {
				dist = Vector3.Distance (go.transform.position, this.transform.position);
				if (dist <= neighborDistance) {
					vCenter += go.transform.position;
					groupSize++;

					if(dist < 0.75f) {
						vAvoid = vAvoid + (this.transform.position - go.transform.position);
					}

					Fish anotherFish = go.GetComponent<Fish> ();
					gSpeed += anotherFish.speed;
				}

			}
		}

		if (groupSize > 0) {
			vCenter = vCenter / groupSize + (goalPos - this.transform.position);
			speed = gSpeed / groupSize;

			Vector3 direction = (vCenter + vAvoid) - transform.position;
			if (direction != Vector3.zero) {
				transform.rotation = Quaternion.Slerp (transform.rotation,
					Quaternion.LookRotation (direction),
					TurnSpeed () * Time.deltaTime);
			}
		}

 	}

	float TurnSpeed() {
		return Random.Range (0.2f, 0.6f);
	}
 }
