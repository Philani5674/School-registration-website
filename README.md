# Matric upgrade registration system

# Guidelines

 ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2019%7C2022-purple)
 ![Framework Version](https://img.shields.io/badge/.Net%20Framework-4.8-blue)

### project Structure

This project comes in two parts

- Main ASP.NET project
- SQL Database project

#### Main ASP.NET project (RegistrationSystem)

- This project includes the ASP.NET **Webforms** and ASP.NET **Web API 2**
- The aslo uses [LibMan](https://devblogs.microsoft.com/dotnet/library-manager-client-side-content-manager-for-web-apps/) to manage client side libraries

#### SQL Database project (MajorProjectDB)

- This project comes all the database tables and views used in the project
- > **NOTE:** You have to **[publish](https://medium.com/hitachisolutions-braintrust/create-your-first-visual-studio-database-project-e6c22e45145b)** the database to your desired SQL Server and change the connection string in web.config to match the one from your SQL-Server

# Config

- ###### (re)build application
  
  (re)building the application will install required ASP packages from NuGet
  
  and Client-Side libraries listed in the``libman.json`` file
  ![build](https://user-images.githubusercontent.com/72506370/147420060-3b16d942-6058-4858-b4b4-0c67ac33dcb2.png)

- ###### publish database
  
  - right-click on ``MajorProjectDB``
  
  ![Publish Database](https://user-images.githubusercontent.com/72506370/147419837-55412f6e-7593-4afa-a5e7-e9ab827cd2e9.jpg)
  
    A tutorial on how to manage and **[publish](https://medium.com/hitachisolutions-braintrust/create-your-first-visual-studio-database-project-e6c22e45145b)** a database project on Visual Studio
  
  > note: Database name is MajorProjectDB
  
  - To the published database add new roles record in the ``AspNetRoles`` table
    ![AspNetRoles](https://user-images.githubusercontent.com/72506370/147420553-c942b6ca-a6c6-4a49-a48d-fd3596b32eeb.png)
  
  - > These roles are required for the application to work properly

- ###### Run Application
  
  > If it happen you encounter error `` could not find a part of path c:\...\bin\roslyn\csc.exe``
  > ![VSbuildError](https://user-images.githubusercontent.com/72506370/147419914-58f73534-83cd-4460-a9bf-bf6f1b6472fd.png)
  > Cleaning and Rebuilding solution usually fix the error. Also refer to [SO solution](https://stackoverflow.com/questions/32780315/could-not-find-a-part-of-the-path-bin-roslyn-csc-exe)


## Some noticable improvements that could be made

- This project may not have the best database design😁, so definatly start with Database Table Relationships (Foriegn Keys)
- Add Teacher's portal (to manage upgrade marks for students)


### Some screenshots

![147422999-c9f1fdd4-ba52-470f-8f9a-e1c4c958d726](https://user-images.githubusercontent.com/62145841/233223729-82377402-cb0f-436b-b806-3501b053c837.png)

![147423028-2228c2b7-110f-4638-a129-a167e129301c](https://user-images.githubusercontent.com/62145841/233223746-af49603c-a06c-4587-9f44-c73e04b8c5ee.png)

![147423054-e42fc809-7fbe-4d47-8a08-e448b60d5eb3](https://user-images.githubusercontent.com/62145841/233223751-8a0dd4a5-05c2-4e19-b730-195ff20f3601.png)

![147423133-2dd0a1a7-6973-4464-99b7-948af9258741](https://user-images.githubusercontent.com/62145841/233223760-b479301b-3194-4319-bb52-8bba1af2a42e.png)




