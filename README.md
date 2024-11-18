# Blazor Hybrid (with .NET MAUI) - Workshop

Today we will build a [Blazor Hybrid](https://learn.microsoft.com/aspnet/core/blazor/hybrid) (based on .NET MAUI) application that will display a list of monkeys from around the world. We will start by building the business logic backend that pulls down json-encoded data from a RESTful endpoint. We will then leverage [.NET MAUI APIs](https://learn.microsoft.com/dotnet/maui/platform-integration/) that can access your devices' location sensors, to find the closest monkey to us and also show the monkey on a map. We will also see how to display data in many different ways and then finally fully theme the application. The user-interface will be powered by [Blazor](https://learn.microsoft.com/aspnet/core/blazor/).

## Setup Guide

Hey there! This workshop will be a hands on and a bring your own device workshop. You can develop on PC or Mac and all you will need to do is install [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/Download) with the .NET MAUI workload and/or .NET MAUI extension. The workshop sample application is built on .NET 9, which means you will need at least version 17.12 of Visual Studio 2022 or newer. If you're using Visual Studio Code, or another code editor, make sure to have the [latest .NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed, also with the .NET MAUI workload.

Before starting the workshop, I recommend going through the quick 10 minute [.NET MAUI Blazor Hybrid Tutorial](https://learn.microsoft.com/aspnet/core/blazor/hybrid/tutorials/maui) that will guide you through installation and also ensuring everything is configured correct.

If you are new to mobile development, we recommend deploying to the platform that you're developing on. If you're on Windows, deploy to Windows first, for macOS deploy to your Mac. Otherwise a physical Android device is a great option and can be setup in just a few steps. If you don't have an Android device, don't worry as you can setup an [Android emulator with hardware acceleration](https://learn.microsoft.com/dotnet/maui/android/emulator/). If you don't have time to set this up ahead of time, don't worry as we are here to help during the workshop.

Beyond that you will be good to go for the workshop, have fun!

## Agenda

I have also put together an abstract of what you can expect for the day long workshop:

* [Part 0](Part%200%20-%20Overview/README.md) - Introduction to .NET MAUI Blazor Hybrid Session & Setup Help
* [Part 1](Part%201%20-%20Displaying%20Data/README.md) - Displaying Data
* [Part 2](Part%202%20-%20Add%20Monkey%20Dialog/README.md) - Add Monkey Dialog  
* [Part 3](Part%203%20-%20Navigation/README.md) - Navigation to Monkey Details Page 
* [Part 4](Part%204%20-%20Platform%20Features/README.md) - Platform Features
* [Part 5](Part%205%20-%20Theming%20the%20app/README.md) - Theming the App
* [Part 6](Part%206%20-%20Advanced%20Topics/README.md) - Advanced Topics (Sharing State, Reusable Components)

To get started open the `Part 1 - Displaying Data` folder and open `MonkeyFinderHybrid.sln`. You can use this throughout the workshop. Each part has a **README.md** file with directions for that part. Also, each part has its own code inside of the folder, and each parts' starting point is where the previous part has left off. This should make it easy to still step into this workshop if you came in later, or you can look ahead in the next part to see the solution when you get stuck.

## Video Walkthrough

Gerald recorded a [full 4-hour walkthrough](https://youtu.be/Ou0k5XKcIh4) end-to-end on his [YouTube](https://youtube.com/@jfversluis)!

## .NET MAUI Workshop

If you're looking to dive deeper into .NET MAUI as well, we have a [very similar workshop](https://github.com/dotnet-presentations/dotnet-maui-workshop) for that as well.

In this workshop you will build the same app as in this one, the Monkey Finder app, but now using just .NET MAUI. By doing both workshops, you can really see the differences and similarities between the two approaches.

## More links and resources:
- [.NET MAUI Blazor Hybrid](https://learn.microsoft.com/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-8.0)
- [.NET MAUI Blazor Hybrid Beginner Series](https://www.youtube.com/playlist?list=PLdo4fOcmZ0oU6AgjUbyztrhnzGVFuN6ij)
- [.NET MAUI Website](https://dot.net/maui)
- [.NET MAUI on Microsoft Learn](https://learn.microsoft.com/learn/paths/build-apps-with-dotnet-maui/)
- [.NET MAUI Documentation](https://learn.microsoft.com/dotnet/maui) 
- [.NET MAUI on GitHub](https://github.com/dotnet/maui)
- [.NET Beginner Series Videos](https://dot.net/videos)

If you have any questions please reach out to us on X (previously Twitter): [@SweekritiS](https://twitter.com/SweekritiS), [@jfversluis](https://x.com/jfversluis) and/or [@maddymontaquila](https://x.com/maddymontaquila).

## Acknowledgements

Special shoutout to [Jimmy Engström](https://github.com/EngstromJimmy) & [James Montemagno](https://github.com/jamesmontemagno) for providing early feedback!
