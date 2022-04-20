................Assignment 2................
Student Name: Utkarsh Patel
Student Number: 0785541


2022-08-02
11:14
Created a web app using MVC along Individual Account Authentication

- Built it
- Created the Readme
- Test it.....


11:17
- Confirmed it runs ok
- Change the welcome message

11:20
- Created a github repo

11:23
- Confirmed that repo created.


2022-22-03
10:50
- clone the project from the Github Rop
- run the app and check everthing works correct

10:55
- Debugg the app and check the code by runninning the particular part in the app.
- looks like everthing working fine.... :)



11:00
- Set up the project witht he Bootstrap
- download the Yeti theme from the Bootswatch.com (bootstrap.css)

11:06
- Modified the code in the following pages:
1. replace the bootstrap.css with the new theme (bootstrap - Yeti).
2. replace the site.css in the wwwroot/css folder provided in the Blackboard.
3. modified the code to include the bootstrap.css while replacing the existing css ie. bootstrap.main.css
4. change the necessary bootstrap text or properties to reflect the theme.


11:20
- run the app to check the theme working properly.
- hurray it works :)


11:34
- Added the third parties tools to the project.
- modified the _Layout.cshtml file in the project.
- Added a code for the Dropdown menu in _Layout.cshtml


11:45
- run the app to check the drop down menu work properly or not
- Hurray it works fine ..... :)


6:40
- now started working on Add Projects and Modify part
- firstly created three different or new project called:
1. UtkarshsBooks.DataAccess
2. UtkarshsBooks.Models
3. UtkarshsBooks.Utility

- Install the neessary packages for the project from the Manage Nuget Packages tab
- Modify the necessary changes for the project.
- finally run the app to check every thing works properly.

- Hurray, Completed my assignment 2 (part 1) :)




**************************************************
********************* All Done *******************
**************************************************










**************************************************
********************* PART 2 *********************
**************************************************


2022/03/29

10:40
- Clone the part 1 from the Github in Visual Studio 2019
- add the Admi  area in the Areas folder
- run the app to check everything works fine
- hurray it works fine :)


1:30
- added a new branch called StartPart2 in the Github
- Check the code and tried to run the app
- everything works fine :)


2:30
- modified the appsettings.json file 
- add the migrations to the .DataAccess file and called it as : 20220329174150_AddDataMigration


3:00
- update the database created in the project by using Package Manager Console Terminal
- Got an error :( of missing Packages for the Project, but hopefully solved when I downloaded the Required Packages to the Projet.

- check the app to see every thing runs perfectly
- Hurray it works :)


3:15
- add a new file called category class file called Category.cs
- add migrations to the project
- update the migrations
- check the category in the SQL SOE

5:16
- added the Repository folder and created the Repository.cs
- and add the IRepository.cs file in the IRepository file
- check the app and it worked fine :)


6:00
- add the CategoryRepository.cs file and ICategoryRepository.cs file 


8:00
- complete the necessary steps or adding the files for the part 2.2 of the Assignment
- files such as :
1. ISP_Class.cs interface file in the IRepository folder.
2. ISP_Class.cs class in the Repository folder.
3. IUnitOfWork.cs interface file in the IRepository folder.
4. IUnitOfWork.cs class in the Repository folder.


9:00
- started workin on the part 2.3 by adding the controller in the Category folder called CategoryController file
- modified the _Layout.cshtml file to include the category link in the project
- check the app by runnin it
- finally it works as expected :)




10:00
- add the command in the package console called : update-database
- check the project file and run the project






*****************************************************
********************* COMPLETED *********************
*****************************************************










**************************************************
********************* PART 3 *********************
**************************************************

2022/04/5

10:00
- clone the project in the Visual studio 2019
- tried to update the database and it done sucessfully
- tried to clean and build the app and chek it wil run or not?
- hurray, it works fine :) till now...........................




11:30
- Added CoverType.cs to the Project particular in the Model's Folder
- Add the cover type Repisitory
1. ICoverTypeRepository in the IRepository Folder
2. CoverTypeRepository in the Repository Folder
3. Add the CoverType to UnitOfWork and IUnitOfWork
4. Push the migrations for the CoverType

- Add the like to the page CoverType to the _Layout.cshtml file
- Add the Index and upsert for the Cover Type.



3:40
- again clone the app again at home in the Visual Studio 2019
- check the app if it will run or not?
- it runs as expected.......


3:55
- started workin on the part 3.2 of the project
- created a file called program.cs
- add migration called "20220405193426_addProductToDb"
- check the table in the SOE


4:00
- add another migrations for the project called 20220405195407_addValidationToProduct
- add the required statement in the class called product


4:45
- completed the first slide of the project
- check that all works good by running the application....
- hurray it works fine :)


10:30
- facing huge error due to the spaces bewtween "Category, CoverType"
- mind got hanged due to that


11:00
- finally solved the error and try to run the app
- Hurray it's work fine... :)


11:30
- Add the code for the tinycloud for the discription and add the script tag for it.
- finally completed the project till 3.3
- and try to run the app
- YEAH GOT IT...............IT RUNS FIIIIIIIIIINNNNNNNNNNNNEEEEEEEEE!!!!!!!!





2022-04-6
- add the functionality to edit the category......


*****************************************************
********************* COMPLETED *********************
*****************************************************





**************************************************
********************* PART 4 *********************
**************************************************


2022-04-19

10:50
- tried to clone the project again  in the Visual Studio 2019
- tried to run the app by updating the database
- sucessfully run the app as of the previous one


10:55
- got the same error as of the previous project ends, particullary in the displaying the products in the products page.
- It was throwing me to the Visual Studio when I tried to add the product to the Database.
- I got the same error as of previous one, the reason is System.InvalidOperationException
- in the file called UnitOfWork.cs, db_SaveChanges()



12:30
- tried to solve the problem of throwing out from the application to the Visual Studio code
- by modifying the code in the Product.cs file
- I got the reference error in the ForeignKey 
- replaced code is  public int CoverTypeId { get; set; } // foreign key reference
        [ForeignKey("CoverTypeId")]

- tried to run the app
- hurray it runs good :) now..............................................



3:40
- tried to display the product on the Home page
- modified the index.cshtml file in the Home folder and HomeController.cs file to include the html part for the Products
- run the app and check the products will displays or not?
- Yeah!!! got it Displayed the products on the HomePage of the project.


2022-04-20

8:00
- Add the require migrations to the project
- faced a lots of error while ading migrations to the Projects in the table
- Error called : ALTER TABLE in the dbo.CoverType table


8:45
- migration added to the projects called:
1. 20220420020229_AddProductNewToDb
2. 20220405195407_addValidationToProduct
3. 20220405150422_AddCoverType1ToDb



9:30
- again got error in the file called : ProductController.cs in the Controller Folder
- throws me to the visual studion when I click the Create button in the product page
- error called :  using (var filesStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))

- solve the error by creating the images/products folder in the wwwroot



10:30
- finally check the app to run the project 
- Hurray it works fine :)
