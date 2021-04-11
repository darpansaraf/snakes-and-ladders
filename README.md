# snakes-and-ladders
a simulation of snakes and ladders game

## Requirements

* Visual Studio 2019, .Net Core 3.1

## Getting Started
To build the application and get started follow the below steps
 
 Step 1:
    clone the GitHub repository, use the below command and paste it in your terminal.
    
    git clone https://github.com/darpansaraf/snakes-and-ladders.git
    
 Step 2:
    Navigate to the 'SnakesAndLadder' Folder
    
 Step 3: 
    Execute the following command on powershell:
    
    dotnet run
    
## Test Cases
    This application has unit tests which are run using xUnit Test Adapter. 
    To Run test cases navigate to the 'SnakesAndLadders.Tests' folder and execute the following command on powershell: 
    
    dotnet test
    
    
## Implementation Approach
    This application calculates the next position of a player on a snakes and ladder board relative the to the current position and dice outcome.
    The application uses FluentValidation to perform some validations on the input and will throw an error if the inputs are not valid.
