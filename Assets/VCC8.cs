﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VCC8 : MonoBehaviour
{
	private bool isInsideCamera;
	public int Eight = 0;
	public int PEight = 0; // プレイヤースコア変数
	public int DEight = 0; // ディーラースコア変数
	public GameObject mark;

	void Update()
	{
		if (isInsideCamera)
		{
			Eight = 8; // カメラにQが見えたら12だけ数字を増やす。
		}
		else
		{
			Eight = 0;// Qが見えなくなったら12だけ数字を減らす。
		}

		//追加部分
		GameObject parent = transform.parent.gameObject;

		if (parent.transform.position.y < mark.transform.position.y)//表示されている画像の位置がディーラー側かどうか
		{
			PEight = Eight;
			DEight = 0;
		}
		else
		{
			DEight = Eight;
			PEight = 0;

		}

	}
	private void OnBecameInvisible()
	{
		isInsideCamera = false;//　カメラ内から出た
	}

	private void OnBecameVisible()
	{
		isInsideCamera = true;//　カメラ内に入った
	}

}
