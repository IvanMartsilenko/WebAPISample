# WebAPISample
Web API application sample via .Net Core

How to Build
Load solution from this repository into your MVS
Write command Add-Migration Migration Name to your package Manager. 
Afterthat Write command Update-Database.

Add NuGet packages: 
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Swashbuckle.AspNetCore.Swagger
Swashbuckle.AspNetCore.SwaggerGen
Swashbuckle.AspNetCore.SwaggerUI

After all you can build that solution.

To get all products use GET https://localhost:5001/products
To get proucts with current id use https://localhost:5001/products/id 
typeof(id) = int

Application Url 
https://localhost:5001
http://localhost:5000

[Route("[controller]")] with controller name is ProductsController, 
so link for GET is https://localhost:5001/products
