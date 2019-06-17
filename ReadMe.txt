# Frameworks - Libraries

1. 
ASP.NET MVC (version 5)
. 
Entity Framework
6.2. 
Ninject
4. 
Moq
RepositoryPattern 

Running Project

- 
Open the project with Visual Studio.
- 
in `web.config`file change the connection string according to your system.
  ```
  
<connectionString><add name="ClinicDB" connectionString="data source=Your data source; initial catalog=Betting;Integrated Security=True" providerName="System.Data.SqlClient" /></connectionString>
  ```
- 

In package manager console run the following commands 
    ```
    
- enable-migrations
  
-  add-migration "Betting"
    
-  update-database
   ```


Run the project. 
Go to   http://localhost:http://localhost:49939/ to see all Odds (GIG-POC-1, GIG-POC-2, GIG-POC-3)

Go to   http://localhost:http://localhost:49939/Admin/Index for admin (GIG-POC-4, GIG-POC-5)
Enjoy