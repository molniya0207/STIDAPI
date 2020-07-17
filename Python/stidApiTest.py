import stidApi

print("Get your API key - https://stopper.website/api/newproject.php")
apiKey = input("Your API Key: ")
stidApi.setApiKey(apiKey)

while True:
    e = input("$ ")
    if e == "login":
        u = input("Login: ")
        z = input("Password: ")
        print(stidApi.Login(u, z))
    if e == "register":
        c = input("Username: ")
        u = input("Login: ")
        z = input("Password: ")
        v = input("Email: ")
        print(stidApi.Register(c, u, z, v))
    if e == "ban":
        u = input("Login: ")
        print(stidApi.Ban(u))
    if e == "getaccess":
        u = input("Login: ")
        print(stidApi.GetAppAccess(u))