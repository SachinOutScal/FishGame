using UnityEngine;
using System.Collections;

public class GlobalFlock : MonoBehaviour {

	public GameObject defaultFish;
	public GameObject[] fishPrefabs;
	public GameObject fishSchool;
	[SerializeField] public int tankSize = 150;

	static int numFish = 30;
	public static GameObject[] allFish = new GameObject[numFish];
	public Vector3 goalPos;

	// Use this for initialization
	void Start () {
		goalPos = Vector3.zero; 
		for (int i = 0; i < numFish; i++) {
			Vector3 pos = new Vector3 (
				Random.Range(-tankSize, tankSize),
				Random.Range(-tankSize/10, tankSize/10),
				Random.Range(-tankSize, tankSize)
			);
			GameObject fish = (GameObject)Instantiate (
				fishPrefabs[Random.Range (0, fishPrefabs.Length)], pos, Quaternion.identity);
			fish.transform.parent = fishSchool.transform;
			allFish [i] = fish;
		}
	}
	
	// Update is called once per frame
	void Update () {
		HandleGoalPos ();
	}

	void HandleGoalPos() {
		if (Random.Range(1, 10000) < 50) {
			goalPos = new Vector3 (
				Random.Range(-tankSize, tankSize),
				Random.Range(-tankSize/10, tankSize/10),
				Random.Range(-tankSize, tankSize)
			);
		}
	}
}
