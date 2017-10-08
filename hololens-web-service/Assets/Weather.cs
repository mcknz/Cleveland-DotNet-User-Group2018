using System;
using System.Collections;
using UnityEngine;

public class Weather : MonoBehaviour
{
    private TextMesh _textMesh;

    // Use this for initialization
    //
    //  https://openweathermap.org
    //  api key: 98b6de91e7196529c5f8a84ccb061be8
    //
    //  url format: http://api.openweathermap.org/data/2.5/forecast?id={city_id}&APPID={APIKEY}
    //  url Worthington OH: http://api.openweathermap.org/data/2.5/forecast?id=5177396&APPID=98b6de91e7196529c5f8a84ccb061be8
    //
    //  "id": 5177396,
    //  "name": "Worthington",
    //  "country": "US",
    //  "coord": {
    //    "lon": -83.01796,
    //    "lat": 40.093121
    //  }
    //
    void Start()
    {
        _textMesh = GetComponent<TextMesh>();

        string url = "http://api.openweathermap.org/data/2.5/forecast?id=5177396&APPID=98b6de91e7196529c5f8a84ccb061be8";
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
    }
    private IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        if (String.IsNullOrEmpty(www.error))
        {
            WeatherResponse response = JsonUtility.FromJson<WeatherResponse>(www.text);
            _textMesh.text = response.list[0].weather[0].description;
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }

    }

}