using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Net;

public class STIDManagerBlock : MonoBehaviour
{
    public bool Login(string login, string password, string devApiKey)
    {
        WebRequest request = WebRequest.Create("http://stopper.website/stid/api/login.php?login=" + login + "&password=" + password + "&api=" + devApiKey);
        WebResponse response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        using (StreamReader reader = new StreamReader(stream))
        {
            if (reader.ReadToEnd() == "true")
            {
                Debug.Log("[STAPI] Login: successful");
                return true;
            }
            else
            {
                Debug.Log("[STAPI] Login: unsuccessful");
                return false;
            }
        }
    }

    public bool Register(string username, string login, string password, string email, string devApiKey)
    {
        WebRequest request = WebRequest.Create("http://stopper.website/stid/api/register.php?username=" + username + "&login=" + login + "&password=" + password + "&email=" + email + "&api=" + devApiKey);
        WebResponse response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        using (StreamReader reader = new StreamReader(stream))
        {
            if (reader.ReadToEnd() == "true")
            {
                Debug.Log("[STAPI] Register: successful");
                return true;
            }
            else
            {
                Debug.Log("[STAPI] Register: unsuccessful");
                return false;
            }
        }
    }

    public bool Ban(string login, string devApiKey)
    {
        WebRequest request = WebRequest.Create("http://stopper.website/stid/api/ban.php?login=" + login + "&api=" + devApiKey);
        WebResponse response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        using (StreamReader reader = new StreamReader(stream))
        {
            if (reader.ReadToEnd() == "true")
            {
                Debug.Log("[STAPI] Ban: successful");
                return true;
            }
            else
            {
                Debug.Log("[STAPI] Ban: unsuccessful");
                return false;
            }
        }
    }

    public bool GetAppAccess(string login, string devApiKey)
    {
        WebRequest request = WebRequest.Create("http://stopper.website/stid/api/checkkey.php?login=" + login + "&api=" + devApiKey);
        WebResponse response = request.GetResponse();
        Stream stream = response.GetResponseStream();
        using (StreamReader reader = new StreamReader(stream))
        {
            if (reader.ReadToEnd() == "true")
            {
                Debug.Log("[STAPI] App Access: successful");
                return true;
            }
            else
            {
                Debug.Log("[STAPI] App Access: unsuccessful");
                return false;
            }
        }
    }
}
