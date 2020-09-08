# NoNodeModulesIntellisense
Just a very small sample for a ReSharper issue I've raised.

I have a simple ASP.NET Core web application that was created with the empty template.

This means there is no wwwroot folder, which is deliberate as I want to us npm to manage non-nuget packages.

I added a very simple view and controller, added a package.json file and included bootstrap and jquery.

Then included node_modules in the project and enabled serving file from that folder using the OdeToCode.UseNodeModules NuGet package.

Now if you open the Index.cshtml file you can see a div at the top.

If I disable ReSharper I get intellisense for all the bootstrap classes. But if I enable Resharper I don't get intellesense for anyting in the node_modules folder.
