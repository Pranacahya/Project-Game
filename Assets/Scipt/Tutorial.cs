using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Tutorial : MonoBehaviour {

	public GameObject main;
	private RawImage img;

	public NextLevel nextlvl;

	public Texture2D texture1;
	public Texture2D texture2;
	public Texture2D texture3;
	public Texture2D texture4;
	public Texture2D texture5;
	public Texture2D texture6;

	public Text TutorialText;

	int choose=0;
	public void Start () 
	{
		img = (RawImage)main.GetComponent<RawImage>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void next()
	{
		choose += 1;
		if (choose == 1) 
		{
			img.texture=(Texture)texture1;
			TutorialText.text="Gunakan Panah Untuk Menggerakkan Pemain";
		}
		else if (choose == 2) 
		{
			img.texture=(Texture)texture2;
			TutorialText.text="Carilah Kunci yang nantinya akan digunakan untuk membuka gerbang";
		}
		else if (choose == 3) 
		{
			img.texture=(Texture)texture3;
			TutorialText.text="Kunci yang kamu dapatkan akan disimpan di Tas";
		}
		else if (choose == 4) 
		{
			img.texture=(Texture)texture4;
			TutorialText.text="Carilah Gerbang Yang cocok dengan kunci yang kamu peroleh";
		}
		else if (choose == 5) 
		{
			img.texture=(Texture)texture5;
			TutorialText.text="Selesaikan soal untuk membuka gerbang. Awas jika salah waktumu berkurang 10 detik";
		}
		else if (choose == 6) 
		{
			img.texture=(Texture)texture6;
			TutorialText.text="Jika Waktumu mencapai (nol) kamu akan kalah";
		}
		else nextlvl.Next();

	}
}
