using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform target;
	private Vector3 offset;     // 相対座標

	void Start ()
	{
		//自分自身とtargetとの相対距離を求める
		offset = GetComponent<Transform> ().position - target.position;
	}

	// Update is called once per frame
	void Update ()
	{
		GetComponent<Transform>().position = target.position + offset;
	}
}
