using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Actions/On-Off")]
public class OnOffRandomAction : Action
{

	public int max=6, min=1, vyhrava=6;
	public float jakDlouho=3;
	public GameObject SkupinaObsahujiciMoznosti;
	public GameObject odhalVyhru;
	public GameObject odhalProhu;

	private bool hazise = false;
	private int rozsah=6, predtim = 1;

	// Changes the object state from active to inactive, and viceversa
	public override bool ExecuteAction(GameObject dataObject)
	{
		rozsah = max - min + 1;
		hazise = true;
		jakDlouho += Random.Range( min, max*10) / 60;
		StartCoroutine(hodkostky());

		return true;
	}

	void Update(){
		if(hazise){
			if(predtim < max-1){
				SkupinaObsahujiciMoznosti.transform.GetChild(predtim).gameObject.SetActive(false);
				predtim++;
				SkupinaObsahujiciMoznosti.transform.GetChild(predtim).gameObject.SetActive(true);
			}
			else{
				SkupinaObsahujiciMoznosti.transform.GetChild(predtim).gameObject.SetActive(false);
				predtim = 0;
				SkupinaObsahujiciMoznosti.transform.GetChild(predtim).gameObject.SetActive(true);
			}
		}
	}

	IEnumerator hodkostky()
	{
		yield return new WaitForSeconds( jakDlouho );
		hazise = false;
		if(predtim + 1 == vyhrava)
			odhalVyhru.gameObject.SetActive(true);
		else
			odhalProhu.gameObject.SetActive(true);
		this.gameObject.SetActive(false);
	}
}
