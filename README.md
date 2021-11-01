# cucumber-csharp
[Cucumber](https://cucumber.io/) is a software tool that supports behavior-driven development (BDD). </br>
[C#](https://docs.microsoft.com/en-us/dotnet/csharp/) is a general-purpose, multi-paradigm programming language.

## Core Concepts
* [Behaviour Driven Development](https://en.wikipedia.org/wiki/Behavior-driven_development) is an agile software development process that encourages collaboration among developers, quality assurance testers, and customer representatives in a software project.
  * Stakeholders might be used to the User Story template; ["As a … I want … So that …"](https://martinfowler.com/bliki/UserStory.html)
  * Developers might be used to a unit test design pattern; ["Arrange, Act, Assert"](http://wiki.c2.com/?ArrangeActAssert)
  * Cucumber expresess functionality using keywords; ["Given, When, Then"](https://en.wikipedia.org/wiki/Given-When-Then)
* [Fluent Interface](https://en.wikipedia.org/wiki/Fluent_interface) is an object-oriented API whose design relies extensively on method chaining.
  * PageObect.someFunction()
  * PageOject.someElement().click()
* [Page Object Model](https://www.selenium.dev/documentation/en/guidelines_and_recommendations/page_object_models/) is a Design Pattern which has become popular in test automation for enhancing test maintenance and reducing code duplication. </br>
  * The "login" screen will have a "Login page object" that contains the selectors for elements on the page and functions that can be performed on that page.

  ## Getting Started
1. Install [NodeJS](https://nodejs.org/en/) LTS
1. [Android] Install [Android Studio](https://developer.android.com/studio) and [create an AVD](https://developer.android.com/studio/run/managing-avds)
1. Clone this repo
1. Open [`CucumberCSharp.sln`](/CucumberCSharp.sln) using [Visual Studio](https://visualstudio.microsoft.com/)
   * If you use [GitHub Desktop](https://desktop.github.com/), select the "Show in Explorer" button and then double-click the `.sln` file
1. Select "Tools" -> "Command Line" -> "Developer PowerShell"
1. Run `npm i appium`
1. In the "Solution Explorer" pane, right-click the solution and then select "Restore NuGet Packages" to install dependencies noted in [AppiumWebdriver.csproj](/AppiumWebdriver/AppiumWebdriver.csproj) and [SeleniumWebdriver.csproj](/SeleniumWebdriver/SeleniumWebdriver.csproj)
1. In the SeleniumWebdriver project create a new file called `.env`
1. Copy+Paste the following
   ```
   TEST_BASE_URL="https://the-internet.herokuapp.com"
   TEST_USER="tomsmith"
   TEST_PASS="SuperSecretPassword!"
   ```
1. Save
1. In the "Solution Explorer" pane, right-click the .env file and select "Properties"
1. Set "Copy to Output Directory" to "Copy always"

## Run Tests

### Appium (Web Apps)
[Appium](https://appium.io) is an open source automation tool for running scripts and testing native applications, mobile-web applications and hybrid applications on Android or iOS using a webdriver. </br>
Example tests use https://developer.android.com/training/basics/firstapp </br>
The [apk](/app-debug.apk) is included as part of _this_ sample repo.

With the [AVD](https://developer.android.com/studio/run/emulator-commandline) running:

   1. Open the `.sln` file using [Visual Studio](https://visualstudio.microsoft.com/)
   1. Select "Test" > "Test Explorer"
   1. Select the desired test(s) and then select "⏵(Run)"


### Selenium (Web Apps)
[Selenium](https://selenium.dev) is an open-source automated testing framework for web applications. </br>
Example tests use https://the-internet.herokuapp.com/login

   1. Open the `.sln` file using [Visual Studio](https://visualstudio.microsoft.com/)
   1. Select "Test" > "Test Explorer"
   1. Select the desired test(s) and then select "⏵(Run)"
