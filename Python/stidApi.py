import requests

api = ""

def setApiKey(key):
    global api
    api = key

def Login(login, password):
    e = requests.get("https://stopper.website/stid/api/login.php", params={'login': login, 'password': password, 'api': api})
    if e.text == "true":
        return True
    else:
        return False

def Register(username, login, password, email):
    e = requests.get("https://stopper.website/stid/api/register.php", params={'username': username, 'login': login, 'password': password, 'email': email, 'api': api})
    if e.text == "true":
        return True
    else:
        return False

def Ban(login):
    e = requests.get("https://stopper.website/stid/api/ban.php", params={'login': login, 'api': api})
    if e.text == "true":
        return True
    else:
        return False

def GetAppAccess(login):
    e = requests.get("https://stopper.website/stid/api/checkkey.php", params={'login': login, 'api': api})
    if e.text == "true":
        return True
    else:
        return False