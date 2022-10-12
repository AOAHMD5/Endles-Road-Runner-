using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using System;
using UnityEngine;

public class AdManager : MonoBehaviour
{

    private BannerView bannerAd;
    private InterstitialAd interstitial;

    public static AdManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(InitializationStatus => { });
        this.RequestBanner();
    }

    private AdRequest createAdRequest()
    {
        return new AdRequest.Builder().Build();
    }

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-8173117650147172~5096849510";
        this.bannerAd = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
        this.bannerAd.LoadAd(this.createAdRequest());
    }

    public void RequestInterstital()
    {
        string adUnitId = "ca-app-pub-8173117650147172~5096849510";
        if (this.interstitial != null)
            this.interstitial.Destroy();

        this.interstitial = new InterstitialAd(adUnitId);


        this.interstitial.LoadAd(this.createAdRequest());
    }

    public void ShowInterstital()
    {
        if(this.interstitial.IsLoaded())
        {
            interstitial.Show();
        }
        else
        {
            Debug.Log("intersital not ready");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
