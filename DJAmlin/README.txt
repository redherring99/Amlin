David Jeffery Nov 2021
dj@drnj.co.uk

************************************************************************************************************
************************************************************************************************************
This development is rushed and NOT AS I WOULD LIKE IT

My mother is in hospital and has had serious surgery to remove her breast - 
she's 82 so it's a big insult to her body plus she lives 200 miles away + covid visiting is making things
difficult.....And I also had to go for an ECG this AM

I AM OUT OF TIME - my plan was to get MVC version working, then use Angular in UI to call WebAPI which would
get the computer's choice then display the result in the UI. But I am out of time

I have a WORKING MVC solution - man v computer and computer v computer + unit testing

What I have done is structure the Solution to have main project, unit test project, extension method project
to give you some idea of how i would structure things. I have done unit tests but these are not exhaustive
but are there to give you some idea of my capabilities. 

Given more time I'd implement the Angular version - I have a webapi endpoint which gives the computer's choice
and the plan was to use Angular in UI - simple ng-app with button click handler which would call endpoint
get the computer's choice then show results on the screen. Also would do 2 x endpoint calls for 
computer v computer. I am sorry that I have no more time. Family circumstances dictate otherwise.


*** I SUSPECT that I am not the developer that you need given my lack of Angular skills and the fact that at
Glencore I did 80+% C# WebAPI backend/SQL ***
************************************************************************************************************
************************************************************************************************************

I am not an Angular.js guru - in fact, I developed with lots of web technologies + JavaScript and then JQuery, 
Angular 1, vue.js and latterly Angular


HTML layout - I've used tables (a no no!) for simplicity rather than divs/stylesheet as don't want to waste time

Solution Layout
---------------

The solution contains main MVC project, a unit test project, a logger extension project. I have done it like this 
to show my development style. I have also used .Net Core 3 rather than .Net 4.7 - this also makes dependency injection 
more straightforward than with .Net 4 and Ninject or Unity DI container/manager ( I have used both extensively)

I NORMALLY have interfaces in separate files to classes - but time is tight so they are in the same files - apologies

Sync/Async
----------

I have gone for Sync here as simpler to code/test. Utilise Async coding pattern and tasked-based-application-programming
(TBAP) style for threading (microsoft recommend Task.Run(()=> {} in place of explicit threading calls))

Logging
--------

I have configured Serlog in the mvc app - a bit of an overkill for a demo but I think logging is very important.
Log format and log location is set in appsettings.json

MVC App
--------

Standard MVC style/layout from VS - I have not messed about with this

Normally I would go for "skinny" controllers and inject business logic into them. However, a time is short
the work is done in the controller code

Also some if/then/else in the razor views - just to show you that I know what I'm doing in Razor


Web API
-------

I have created a WebAPI for Get rock/paper/scissors randomly - Done to show use of WebAPI and "ajax" 
rather than for any great technical merit.

Unit Testing
-------------

I have a .cs unit test project for testing the main "logic" - I have not gone overboard but have done this to
show my TDD style of work (I don't particularly like TDD but rather code first then write the test as I think
TDD leads to poor quality code that "just" passes the test).

I tend use the Arrange/Act/Assert style of unit testing - with the builder pattern http://www.natpryce.com/articles/000714.html
for fake data. The builder pattern avoids lots of common/base-class test/fake data setup - which then has to be refactored,
it means that each test is more or less self-contained.

I like NSubsitute over MOQ but sometimes callbacks are a little bit trickier than with MoQ. I have used MoQ extensively
I use NBuilder where I can.
I prefer "Fluent Assertions" over Assert.xxx as I think it makes the code more readable.

UI Unit Testing
---------------

Honesty: Not my strong point as no real experience with protractor etc. I can do it but just need a day to learn

