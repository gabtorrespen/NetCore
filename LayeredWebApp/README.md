
# NetCore Layered architecture

For the **first run** of the project you have to: 

 - It is required that you have installed the **localdb** database for SQL. Documentation can be found [here](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15)
 - Double click in the **App.Database.publish.xml** file under the **App.Database** project and then click the **Publish** button
 - If you want to use a specific SQL server you can modify the publish settings in the previous step and point to a specific target SQL server and database. If that's the case please change the connection string under the respective environment **appsettings.json** file 