using UnityEngine;
using System.Collections;
using StartApp;

public class GameObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Debug.Log("Loading ad code");
		//StartAppWrapper.loadAd();
		//StartAppWrapper.showAd();
		#if UNITY_ANDROID
		   StartAppWrapper.addBanner( 
           StartAppWrapper.BannerType.AUTOMATIC,
           StartAppWrapper.BannerPosition.BOTTOM);
		#endif
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void onReceiveAd()	{
	
	}	
	public void onFailedToReceiveAd()	{
	
	}
}
