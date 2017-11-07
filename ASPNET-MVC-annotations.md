# MVC

## ROUTING
ASP.NET MVC invokes different controller classes (and different action methods within them) depending on the incoming URL. The default URL routing logic used by ASP.NET MVC uses a format like this to determine what code to invoke:  
```cs
/[Controller]/[ActionName]/[Parameters]
```  
You set the format for routing in the App_Start/RouteConfig.cs file.
