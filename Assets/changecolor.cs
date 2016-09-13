using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changecolor : MonoBehaviour {

    public Slider Rs;
    public Slider Gs;
    public Slider Bs;
    public Slider As;

    public Text RV;
    public Text GV;
    public Text BV;
    public Text AV;

    private int RVa;
    private int GVa;
    private int BVa;
    private int AVa;

    private Vector4 aaa;

    public GameObject myCube;

    void Start()
    {
        myCube = GameObject.Find("car");
        //Debug.Log(myCube.GetComponent<Renderer>().material.color);
        Debug.Log(myCube.GetComponentInChildren<Renderer>().materials[0].color);
        myCube.GetComponentInChildren<Renderer>().materials[0].color = new Color(128.0f, 128.0f, 128.0f, 128.0f);
    }
        void Update()
    {
        myCube.GetComponentInChildren<Renderer>().materials[0].color = new Color(Rs.value/255.0f, Gs.value / 255.0f, Bs.value / 255.0f, As.value / 255.0f);
        RVa = (int)Rs.value;
        RV.text = RVa.ToString("D3");
        GVa = (int)Gs.value;
        GV.text = GVa.ToString("D3");
        BVa = (int)Bs.value;
        BV.text = BVa.ToString("D3");
        AVa = (int)As.value;
        AV.text = AVa.ToString("D3");

        if (Input.GetButton("L"))
        {
            if (Input.GetButton("A"))
            {
                Gs.value -= 1;
            }
            if (Input.GetButton("B"))
            {
                Rs.value -= 1;
            }
            if (Input.GetButton("X"))
            {
                Bs.value -= 1;
            }
            if (Input.GetButton("Y"))
            {
                As.value -= 1;
            }
        }

        if (Input.GetButton("R"))
        {
            if (Input.GetButton("A"))
            {
                Gs.value += 1;
            }
            if (Input.GetButton("B"))
            {
                Rs.value += 1;
            }
            if (Input.GetButton("X"))
            {
                Bs.value += 1;
            }
            if (Input.GetButton("Y"))
            {
                As.value += 1;
            }
        }
    }
}
