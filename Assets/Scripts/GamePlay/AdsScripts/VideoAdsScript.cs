using GoogleMobileAds.Api;
using UnityEngine;
using System;

public class VideoAdsScript : MonoBehaviour
{
    private RewardBasedVideoAd rewardBasedVideo;

    public void Start()
    {
        /* Needed
         * 
        string appId = "ca-app-pub-6338977167328988~3985994970";

        MobileAds.Initialize(appId);
        */

        // Get singleton reward based video ad reference.
        this.rewardBasedVideo = RewardBasedVideoAd.Instance;

        //  RewardBasedVideoAd is a singleton, so handlers should only be registered once.
        //  this.rewardBasedVideo.OnAdLoaded += this.HandleRewardBasedVideoLoaded;
        //  this.rewardBasedVideo.OnAdFailedToLoad += this.HandleRewardBasedVideoFailedToLoad;
        //  this.rewardBasedVideo.OnAdOpening += this.HandleRewardBasedVideoOpened;
        //  this.rewardBasedVideo.OnAdStarted += this.HandleRewardBasedVideoStarted;
        this.rewardBasedVideo.OnAdRewarded += this.HandleRewardBasedVideoRewarded;
        this.rewardBasedVideo.OnAdClosed += this.HandleRewardBasedVideoClosed;
        //  this.rewardBasedVideo.OnAdLeavingApplication += this.HandleRewardBasedVideoLeftApplication;

        this.RequestRewardBasedVideo();
    }
   
    public void Click()
    {
        this.rewardBasedVideo.Show();
    }

    // Returns an ad request with custom ad targeting.
    private AdRequest CreateAdRequest()
    {
        return new AdRequest.Builder().Build();
    }

    private void RequestRewardBasedVideo()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.rewardBasedVideo.LoadAd(this.CreateAdRequest(), adUnitId);
     // this.ShowRewardBasedVideo();
    }

    /*
    private void ShowRewardBasedVideo()
    {
        
    }
    */
    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        FindObjectOfType<ScoreTextScript>().ContinueCall();
    }

    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {
        FindObjectOfType<ScoreTextScript>().NoThanksCall();
    }


    /*  #region RewardBasedVideo callback handlers

      public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
      }

      public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
      {
          MonoBehaviour.print(
              "HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);
      }

      public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
      }

      public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
      }

      public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
      {
          MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
      }
      #endregion*/

}