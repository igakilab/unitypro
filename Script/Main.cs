using UnityEngine;
using System.Collections;
using Vuforia;

public class Main : MonoBehaviour {
	public Obj01 Obj01;
	public Obj02 Obj02;
	public Obj03 Obj03;
	public Obj04 Obj04;
	public Obj05 Obj05;
	public Obj06 Obj06;
	public Obj07 Obj07;
	public Obj08 Obj08;
	public Obj09 Obj09;
	public Obj10 Obj10;
	public Obj01 Obj11;
	public Obj02 Obj12;
	public Obj03 Obj13;
	public Obj04 Obj14;
	public Obj05 Obj15;
	public Obj06 Obj16;
	public Obj07 Obj17;
	public Obj08 Obj18;
	public Obj09 Obj10;
	public Obj10 Obj20;
	private GUIStyle m_guiStyle;
	private GUIStyleState m_styleState;
	GameObject kaiten01;
	GameObject kaiten02;
	GameObject kaiten03;
	GameObject kaiten04;
	GameObject kaiten05;
	GameObject kaiten06;
	GameObject kaiten07;
	GameObject kaiten08;
	GameObject kaiten09;
	GameObject kaiten10;
	GameObject kaiten11;
	GameObject kaiten12;
	GameObject kaiten13;
	GameObject kaiten14;
	GameObject kaiten15;
	GameObject kaiten16;
	GameObject kaiten17;
	GameObject kaiten18;
	GameObject kaiten19;
	GameObject kaiten20;
	public static int flg01=0;
	public static int flg02=0;
	public static int flg03=0;
	public static int flg04=0;
	public static int flg05=0;
	public static int flg06=0;
	public static int flg07=0;
	public static int flg08=0;
	public static int flg09=0;
	public static int flg10=0;
	public static int flg11=0;
	public static int flg12=0;
	public static int flg13=0;
	public static int flg14=0;
	public static int flg15=0;
	public static int flg16=0;
	public static int flg17=0;
	public static int flg18=0;
	public static int flg19=0;
	public static int flg20=0;
	public static int SoundFlg=0;
	public AudioClip audioClip;
	AudioSource audioSource;

	void Start() {
		//Ssend = GetComponent<Script1>();
		//print ("Trac");
		//someScript = Send.GetComponent<SomeScript> ();
		kaiten01 = GameObject.Find ("Obj01");
		kaiten02 = GameObject.Find ("Obj02");
		kaiten03 = GameObject.Find ("Obj03");
		kaiten04 = GameObject.Find ("Obj04");
		kaiten05 = GameObject.Find ("Obj05");
		kaiten06 = GameObject.Find ("Obj06");
		kaiten07 = GameObject.Find ("Obj07");
		kaiten08 = GameObject.Find ("Obj08");
		kaiten09 = GameObject.Find ("Obj09");
		kaiten10 = GameObject.Find ("Obj10");
		kaiten11 = GameObject.Find ("Obj11");
		kaiten12 = GameObject.Find ("Obj12");
		kaiten13 = GameObject.Find ("Obj13");
		kaiten14 = GameObject.Find ("Obj14");
		kaiten15 = GameObject.Find ("Obj15");
		kaiten16 = GameObject.Find ("Obj16");
		kaiten17 = GameObject.Find ("Obj17");
		kaiten18 = GameObject.Find ("Obj18");
		kaiten19 = GameObject.Find ("Obj19");
		kaiten20 = GameObject.Find ("Obj20");
		m_guiStyle = new GUIStyle();
		m_guiStyle.fontSize = 999;
		
		m_styleState = new GUIStyleState();
		m_styleState.textColor = Color.red;   // 文字色の変更.
		m_guiStyle.normal = m_styleState;
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = audioClip;
	}
	void Update() {
		//Destroy(Cube1, 2.0f);
		//if (Cube1 == null) {
		//}
		//Send one1 = Cube2.GetComponent<Send>().OnBecameInvisible();
		//a = one1.OnBecameInvisible ();
		//print ("Cube1");
		//print("Cube2 = "+ Cube2.transform.position.x + Cube2.transform.localPosition.y + Cube2.transform.localPosition.z);
		//Cube2.Rotate(45, 90, 180);
		//print(Cube1.cube1);
		//print(Cube2.cube2);
		
		
		if (Obj01.obj01 == 1 && Obj02.obj02 == 1) {
			flg01 = 1;
		} else if(Obj03.obj03 == 1 && Obj04.obj04 == 1) {
			flg02 = 1;
		} else if(Obj05.obj05 == 1 && Obj06.obj06 == 1) {
			flg03 = 1;
		} else if(Obj07.obj07 == 1 && Obj08.obj08 == 1) {
			flg04 = 1;
		} else if(Obj09.obj09 == 1 && Obj10.obj10 == 1) {
			flg05 = 1;
		} else if(Obj11.obj11 == 1 && Obj11.obj12 == 1) {
			flg06 = 1;
		} else if(Obj14.obj14 == 1 && Obj13.obj13 == 1) {
			flg07 = 1;
		} else if(Obj15.obj15 == 1 && Obj16.obj16 == 1) {
			flg08 = 1;
		} else if(Obj17.obj17 == 1 && Obj18.obj18 == 1) {
			flg09 = 1;
		} else if(Obj19.obj19 == 1 && Obj20.obj20 == 1) {
			flg10 = 1;
		}
			
			
		if(flg01==1){
			kaiten01.transform.Rotate(2,3,2);
			kaiten02.transform.Rotate(2,3,2);
			Sound();
		}
		else if(flg02==1)
			kaiten03.transform.Rotate(2,3,2);
			kaiten04.transform.Rotate(2,3,2);
			Sound();
			}
		}
		else if(flg03==1){
			kaiten05.transform.Rotate(2,3,2);
			kaiten06.transform.Rotate(2,3,2);
			Sound();
			}
		}
		else if(flg04==1)
			kaiten07.transform.Rotate(2,3,2);
			kaiten08.transform.Rotate(2,3,2);
			Sound();
			}
		}
		else if(flg05==1)
			kaiten09.transform.Rotate(2,3,2);
			kaiten10.transform.Rotate(2,3,2);
			Sound();

		}
		else if(flg06==1)
			kaiten11.transform.Rotate(2,3,2);
			kaiten12.transform.Rotate(2,3,2);
			Sound();
		}
		else if(flg07==1)
			kaiten13.transform.Rotate(2,3,2);
			kaiten14.transform.Rotate(2,3,2);
			Sound();
		}
		else if(flg08==1)
			kaiten15.transform.Rotate(2,3,2);
			kaiten16.transform.Rotate(2,3,2);
			Sound();
		}		
		else if(flg09==1)
			kaiten17.transform.Rotate(2,3,2);
			kaiten18.transform.Rotate(2,3,2);
			Sound();
		}	
		else if(flg10==1)
			kaiten19.transform.Rotate(2,3,2);
			kaiten20.transform.Rotate(2,3,2);
			Sound();
		} else {
			SoundFlg = 0;
		}

}

	void OnGUI(){
	
		if(flg01 ==1 || flg02 == 1 || flg03 == 1
		   flg04 ==1 || flg05 == 1 || flg06 == 1
		   flg07 ==1 || flg08 == 1 || flg09 == 1 flg10 ==1){
			GUI.Label (new Rect (90, 40, 80, 20), "正　 解", m_guiStyle);
		} else {
			GUI.Label(new Rect(90, 40, 80, 20), "し　 ね", m_guiStyle);
		}
	}

	void Suond(){
		if (SoundFlg == 0) {
		audioSource.PlayOneShot (audioClip, 0.7F);
		SoundFlg = 1;
		}
	}
	//public void OnBecameVisible(){
	//	print (Cube1);
	//}
	/**
	// Use this for initialization
	void Start () {
		Cube1 = GameObject.Find("Cube1");
		Cube2 = GameObject.Find("Cube2");
	}
	
	// Update is called once per frame
	void Update () {
		print("unity1 = "+ Cube1.transform.localPosition.x + Cube1.transform.localPosition.y + Cube1.transform.localPosition.z);
		print("Cube2 = "+ Cube2.transform.localPosition.x + Cube2.transform.localPosition.y + Cube2.transform.localPosition.z);
		//GameObject[] objs = GameObject.FindGameObjectsWithTag("unity");
		//foreach(GameObject obj in objs){
		//}
		//print (a);
	}
	**/
}
