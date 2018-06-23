using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FantasyMons : MonoBehaviour {
    public Text m1;
    public Text m2;
    public Text m3;
    public Text m4;
    //these are for testing
    Fantasymon f1 = new Fantasymon("Kankan","tackle","fart","jump","claw");//your monster
    Fantasymon f2 = new Fantasymon("Dino","tackle","move","shit","sprint");//enemy monster

	// Use this for initialization
	void Start () {
        m1.text = f1.GetM1();
        m2.text = f1.GetM2();
        m3.text = f1.GetM3();
        m4.text = f1.GetM4();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

class Fantasymon
{
    private string name;
    private string m1;
    private string m2;
    private string m3;
    private string m4;

    public Fantasymon(string name, string m1, string m2, string m3, string m4)
    {
        this.name = name;
        this.m1 = m1;
        this.m2 = m2;
        this.m3 = m3;
        this.m4 = m4;
    }

    public string GetName() {
        return this.name;
    }
    public string GetM1()
    {
        return this.m1;
    }
    public string GetM2()
    {
        return this.m2;
    }
    public string GetM3()
    {
        return this.m3;
    }
    public string GetM4()
    {
        return this.m4;
    }
    public void SetName(string name) {
        this.name = name;
    }
    public void SetM1(string m1)
    {
        this.m1 = m1;
    }
    public void SetM2 (string m2)
    {
        this.m2 = m2;
    }
    public void SetM3(string m3)
    {
        this.m3 = m3;
    }
    public void SetM4(string m4)
    {
        this.m4 = m4;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}