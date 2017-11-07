# MVC

## About MVC  
*MVC* stands for model-view-controller. MVC is a pattern for developing applications that are well architected, testable and easy to maintain. MVC-based applications contain:
* **M** odels: Classes that represent the data of the application and that use validation logic to enforce business rules for that data.
* **V** iews: Template files that your application uses to dynamically generate HTML responses.
* **C** ontrollers: Classes that handle incoming browser requests, retrieve model data, and then specify view templates that return a response to the browser.

*About ASP.NET MVC*: It gives you a powerful, patterns-based way to build dynamic websites that enables a clean separation of concerns and that gives you full control over markup for enjoyable, agile development. ASP.NET MVC includes many features that enable fast, TDD-friendly development for creating sophisticated applications that use the latest web standards.  

### Controller  
Controller classes are invoked in response to an incoming URL request. A controller class is where you write the code that handles the incoming browser requests, retrieves data from a database, and ultimately decides what type of response to send back to the browser. View templates can then be used from a controller to generate and format an HTML response to the browser. 

### View  
**A view template should never perform business logic or interact with a database directly**. Instead, a view template should work only with the data that's provided to it by the controller. Maintaining this "separation of concerns" helps keep your code clean, testable and more maintainable.

## ROUTING
ASP.NET MVC invokes different controller classes (and different action methods within them) depending on the incoming URL. The default URL routing logic used by ASP.NET MVC uses a format like this to determine what code to invoke:  
```cs
/[Controller]/[ActionName]/[Parameters]
```  
You set the format for routing in the App_Start/RouteConfig.cs file.
