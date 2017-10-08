# HoloLens web service PoC

This repo contains a Unity project (Unity 2017.1.0b9) that can be built and deployed to Microsoft HoloLens.

The project demonstrates how to consume and display data from a RESTful web service, by displaying the current weather conditions in Worthington, Ohio (USA).

Steps to accomplish this are as follows:

1. Create an account with https://openweathermap.org to obtain an API key
2. Consult the API docs to request current weather for a given city ID at https://openweathermap.org/current#cityid
3. Find the ID for the city to request by downloading city.list.json.gz from http://bulk.openweathermap.org/sample/ (Worthington, OH is 5177396)
4. Craft a URL that will request weather information for a given city http://api.openweathermap.org/data/2.5/forecast?id=5177396&APPID={API_KEY}";
5. Add a 3D Text Mesh object to the Unity scene
6. Add a C# script to the 3D Text Mesh object
7. Create an instance of the UnityEngine.WWW utility module, using the API URL
8. Pass the WWW instance to a Coroutine to receive the API reponse
9. Use the JsonUtility.FromJson method to populate local classes with weather data
10. Set the text property of the 3D Text Mesh object to the local weather description

Build settings are part of the Library directory, which the Unity docs recommend to [leave out of version control][1].

To configure a Unity build for HoloLens:

1. Go to File | Build Settings...
2. Add the "Main" Scene to the build
3. Select "Universal Windows Platform" as the platform, and set the options as follows:
    1. **Target Device**:     HoloLens
    2. **Build Type**:    D3D
    3. **SDK**:               Latest installed
    4. **Build and Run on**:  Local Machine
    5. **Unity C# Projects**: checked

4. Create an "App" directory in root, and select that folder for build


[1]: https://docs.unity3d.com/2017.1/Documentation/Manual/ExternalVersionControlSystemSupport.html

