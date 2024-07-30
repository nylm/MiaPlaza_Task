# Sample UI test automation for Miaplaza app
This repository contains sample UI end-to-end test automation framework for [MiapLaza](https://miacademy.co/#/).

This automation framework is developed using Selenium, C# and Nunit.

## Features

- **Selenium WebDriver** for interacting with web elements.
- **NUnit** for writing and running tests.
- **Page Object Model** (POM) design pattern for better maintainability.


## Prerequisites

Before you can run the tests, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (Version 8.0 or later recommended)
- [Visual Studio Code](https://code.visualstudio.com/) or another IDE of your choice
- Google Chrome


## Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/nylm/MiaPlaza_Task.git

1. **Navigate to the Project Directory**
   ```bash
   cd MiaPlaza_Task

1. **Restore .NET Dependencies**
    ```bash
   dotnet restore

## Running Tests

    ```bash
    dotnet test

## Project Structure

Current Structure:
- `miaplaza/`
  - `Pages/`:  Contains page object model classes that represent the pages of the web application.
  - `Tests/`: Contains the test suites & cases to perform actions and assertions.
 
The Project can be further improved by implementing:
- **Data-Driven Testing** with JSON configuration files.
- **Cross-Browser Testing** support multiple browsers.
  
  - `Data/`: Will contain JSON files or other data sources used for data-driven testing.
  - `Drivers/`: Will contain browser driver binaries (e.g., chromedriver, firefox ..).
  - `Utilities`: Will contain utility classes and helpers used throughout the tests.
  

