# Vuture

## .NET Core Recruitment Test (C#)

The purpose of this test is to be used to assess the technical capabilities of candidates during the hiring for a position at Vuture.
Please read all of the instructions carefully.

### Purpose of this test

* We are looking to see if you can write code that is clean and reusable
* Do you understand SOLID, DRY and all the other acronyms involved with .NET development
* Part of the role will be implementing controllers, handling data from a database or 3rd party service
* The test is an insight into how you would develop and improve an existing code base

### Background

Vuture integrates with leading CRMs to automatically extract and update data. Our system was originally built as an easy to use CMS.
This test is focused on Contacts, a user or entity which would come from one of our clients CRM via a 3rd party integration into our Vuture product.
In this test, we have removed the need for a 3rd party integration and simply used an In-Memory database as the store of this information.

### Instructions

* Throughout the code there are partially completed functionality from the Controllers to the Service and finally the Repository.
* We would like you to complete this functionality so it is possible to Create, Update, Retrieve and Delete a Contact.
* It is important to use the foundations which have already be created so make sure to use the data models and utilise the DTOs
* This test uses an in-memory entity framework database, so if you restart the application any data you entered will be lost
* We have kindly added some data to the database as part of the application start process to make your development easier
* Don't forget to write unit tests so you can verify that your code does as you expect it to

### Bonus

* Extend your code to not allow multiple contacts with the same email address, use an appropriate exception
* Create a new controller endpoint for retrieving all of the users from a passed in company e.g. Vuture, CM Group or any other string

### Important

* Use the models to validate and sanitize input/outputs
* Interact with the database via the Repository classes
* Observability of any application is crucial, consider best how to use Logger

## Getting started

* Fork or clone the repository, we would love to see your commit history
* Use a code editor of your choice
* Make sure to install Dotnet [entity framework tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)
* This test uses .NET 6.0, make sure you have the necessary SDK installed
* You can use the already set up [SwaggerUI](https://localhost:3000/swagger/index.html) for manual testing

## Think you are finished?

* Have you implemented all of the methods within the controller?
* Have you verified and considered edge cases?
* Take another look at your code structure, does it follow good coding standards?

## Let us know you are finished

* You will need to share the repository with us, please share with us a link to your repository
* We will review your code and provide feedback via TalentPoint
* If you have any questions throughout, please feel free to get in contact with us [charly.webster@vutu.re](mailto:charly.webster@vutu.re) [simon.humphries@vutu.re](mailto:simon.humphries@vutu.re) [daniel.bottiglieri@vutu.re](mailto:daniel.bottiglieri@vutu.re)
