using System.IO;
using System.Net;

namespace StopperTech
{
public class STIDAPI
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
                return true;
            }
            else
            {
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
                return true;
            }
            else
            {
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
                return true;
            }
            else
            {
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
}