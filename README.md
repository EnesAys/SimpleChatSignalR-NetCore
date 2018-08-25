# SimpleChatSignalR-NetCore

.Net Core 2.1 and SignalR simple chat example



# Progress Steps



Create your .net core solution

dotnet new mvc or select visual studio template



Add Microsoft.AspNetCore.SignalR for server side


Update your startup.cs
 
in ConfigureServices method  add services.AddSignalR();

in Configure method          add app.UseSignalR(routes => { routes.MapHub<ChatHub>("/chat");
});



Create your hub class and inherit SignalR Hub Class

Write your own Method for send message



Create a package.json file, in package manager console

npm init -y



Install client signalr package,in package manager console

npm install @aspnet/signalr

npm install



Create a signalr folder in wwwroot/lib


Copy signalr.js from YourProjectFolder/node_modules/@aspnet/signalr/dist/browser to signalr folder



add  <script src="~/lib/signalr/signalr.js"></script> <script src="~/js/chat.js"></script> in your -Layout page      



Create chat.js file in wwwroot/js , connect your hub and write your function



Create your client-side page




https://docs.microsoft.com/tr-tr/aspnet/core/tutorials/signalr?view=aspnetcore-2.1&tabs=visual-studio