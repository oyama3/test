using UnityEngine;
using System.Collections;

public class cont : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //左スティック（今までと同じ）
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            //上に傾いている
            Debug.Log("ue!");
        }
        else if (0 < Input.GetAxisRaw("Vertical"))
        {
            //下に傾いている
            Debug.Log("Shita!");
        }
        else
        {
            //上下方向には傾いていない
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //左に傾いている
            Debug.Log("Left");
        }
        else if (0 < Input.GetAxisRaw("Horizontal"))
        {
            //右に傾いている
            Debug.Log("Right!");
        }
        else
        {
            //左右方向には傾いていない
        }


    }
}
