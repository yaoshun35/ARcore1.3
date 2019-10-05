using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Xiaoyisi_InteractiveObj : MonoBehaviour {

    //public PlayMakerFSM pm;

    public Animator an;
    public float OriSpeed;

    public string fishName;
    public AudioClip fishSound;
    public Text introText;
    public AudioSource introAs;


    private bool isThisFishNew=true;

	// Use this for initialization
	void Start () {

        an = this.GetComponent<Animator>();
        OriSpeed = an.speed;

        introText = GameObject.Find("introText").GetComponent<Text>();
        introAs= GameObject.Find("introText").GetComponent<AudioSource>();
        //an.speed = 0.0f;
    }
	
	// Update is called once per frame
	void Update () {
		

	}

	public void hovered(){

        an.speed = 0.0f;
        
      

    }


	public void activated(){

        introText.text = fishName;
        if (fishSound != null) {

            introAs.clip = fishSound;
            introAs.Play();

        }

        if (isThisFishNew)
        {
           // Manager.addFish();

            isThisFishNew = false;

        }
        
        //an.speed = OriSpeed;

        



    }


	public void leave(){


        an.speed = OriSpeed;
    }
}
