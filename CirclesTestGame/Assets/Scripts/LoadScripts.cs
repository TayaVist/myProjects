using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadScripts : MonoBehaviour
{
    [SerializeField] AudioSource source;
    void Start()
    {
        var myLoadedAssetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "content/allcontent"));
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            return;
        }

        try
        {
            var musicRequest = myLoadedAssetBundle.LoadAsset<AudioClip>("wellbegonebythen.mp3");
            //var musicRequest = myLoadedAssetBundle.LoadAssetAsync(musicName, typeof(AudioClip));
            Debug.Log("Музыка распакована");
            try
            {
                source.GetComponent<AudioSource>().clip = musicRequest;
                //source = GetComponent<AudioSource>();
                //source.clip = musicRequest as AudioClip;
                source.Play();
                Debug.Log("не лажа");
            }
            catch
            {
                Debug.Log("лажа ");
            }
        }
        catch
        {
            Debug.Log("лажа распаковки");
        }
       
        
        

    }

    /*string bundleURL = "";
    private int version = 0;
    [SerializeField] AudioSource source;
    public void OnClickDownload()
    {
        StartCoroutine(DownloadAndCache());
    }
    IEnumerator DownloadAndCache() { 
    while(!Caching.ready)        
            yield return null;

            var www = WWW.LoadFromCacheOrDownload(bundleURL, version);
            yield return www;
        if(!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
            yield break;
        }
        Debug.Log("Бандл загружен");

        var assetBundle = www.assetBundle;
        string musicName = "crozet wellbegonebythen.mp3";

        var musicRequest = assetBundle.LoadAssetAsync(musicName, typeof(AudioClip));
        yield break;
        Debug.Log("Музыка распакована");

        source.clip = musicRequest.asset as AudioClip;
        source.Play();*/

    //}
}
