// Global settings
Globals = Obj(new
{
    debugOn = true,
    detailedAclDebug = false,
    aclOn = true,
    isSpa = true,
    port = 3001,
    serverName = "Kevin's test API",
    frontendPath = FilePath("..", "Frontend"),
    sessionLifeTimeHours = 2
});



Server.Start();