C# FUNDAMENTALS: Week 1 – Homework PacketCoding challenges help you grow in skill as a developer by not only reinforcing concepts, but also by making you think about solving problems in new ways. The below challenges utilize the concepts that you learned in week one, culminating in the development of your first program that utilizes real-world concepts – the ATM.  The exercises leading up to the ATM are warm-up questions that reiterate important concepts, and your solutions for these exercises may be used in the ATM.  All labs will be reviewed on Monday of CSF2 for completion. 

SECTION 1: Project Setup1.Create a new Solution/Project called CSF1Homework2.Create a new class for each problem below a.Example: CSF1 class solution – each project has multiple classes  

SECTION 2: Warm Up ExercisesVARIABLES Class: 

Variables.cs1. Create a variable of type int and assign a value to it.  Display the value of the variable 
a. Do the same for 
  i. Char 
  ii. String 
  iii. Double 
  iv. Float 
  v. Byte  
2. Create an array of 5 ints and assign different values to each element.  Write a Foreach loop to display all of the values in your array. a. Do the same for  i. Char ii. String iii. Double iv. Float v. Byte  
3. Create a program that counts from 0 to 100 by 2’s (displaying onscreen) using a While loop. 
  a. Do the same for  
    i. A Do While loop 
    ii. A For loop 
© 2020 Centriq Training. All Rights Reserved.

FRUIT LOOPSClass: FruitLoop1.csDeclare and initialize an array of any six fruit names (as text). Set up a WHILE loop and iterate through them (displaying each value in the console.) Example Reference: Array.cs class in _3Wednesday & LoopingWhile.cs class in _5FridayClass: 

FruitLoop2.csRepeat the previous exercise to use a FOR loop Example Reference: Array.cs class in _3Wednesday & LoopingFor.cs class in _5FridayClass: 

FruitLoop3.csRepeat the previous exercise, but for each of the fruit names that you display, on the next line display a number of periods that is equal to the number of the index of the array. Output Example: “Apple”. //one periodExample Reference: Array.cs class in _3Wednesday & LoopingFor.cs class in _5FridayHint: Two common solutions include EITHER a string array OR nesting a second FOR loop to generate the required number of periods. 

COUNTINGClass: Counting.cs1.Display numbers from 1 to 25 on the screen with a loop.2.Display numbers from 25 to 1 on the screen with a loop.3.Display numbers from 0 to 50 by 2’s with a loop.  4.Display numbers from 1 to 10 by 0.5 with a loop.  Example Reference: All Looping classes in _5Friday. 

POWERSClass: Powers.cs Use a FOR loop to display the powers of 2 from 1 to 50 (2 to the 1st power through 2 to the 50th power). Use a long variable to store your results and do not use methods from the Math class.  Example Reference: Looping classes in _5Friday. 

MINMAXAVGClass: MinMaxAvg.cs Write a program that asks the user for 5 numbers and outputs the lowest number, the highest number, and the average number. Be sure to test with a case where all numbers input are negative. 
© 2020 Centriq Training. All Rights Reserved.Example Reference: Arrays.cs class in _3Wednesday & Looping classes in _5Friday. 

INTEREST Class: InterestCalc.csWrite a program that asks the user for a beginning balance, interest rate, and a number of years. Print the amount of money they would have after the specified number of years if the money is compounded annually. For example: Example Reference: Operators.cs class in _2Tuesday, InputLab.cs class in _3Wednesday, and LoopingFor.cs class in _5Friday. 

GRADES Class: Grades.csWrite a program that asks the user for scores and then displays the total number of scores, and the total number of scores given for each grade (A = 90+, B = 89-80, C = 70-79, D = 60-69, F = below 60). The program should stop asking for more scores when the user enters a negative score. For example:Example Reference: LoopingDoWhile.cs class in _5Friday. 

MAD LIB Class: MadLib.csCreate a “mad lib” that asks the user for various pieces of information. Store the information as strings. Once the information has been collected, output a story using the stored information. (Example below with resulting “mad lib story”):   
© 2020 Centriq Training. All Rights Reserved.Example Reference: InputLab.cs class in _3Wednesday. 

TEMPERATURE CONVERTERClass: TempConverter.cs1.First, write a program that asks the user for a temperature in Celsius and converts it to Fahrenheit. The conversion is done by multiplying the Celsius temp by 9/5 and then adding 32. (fah = cel * (9.0/5.0) +32). When testing your program, use 100 degrees Celsius as an example – the result should be 212 degrees Fahrenheit.    

2.Next write additional functionality that asks the user for a Fahrenheit temperature and converts it to Celsius. The conversion is done by taking the Fahrenheit temperature, subtracting 32, then dividing by 9/5.(cel = (fah – 32) / (9.0/5.0)  

3.Next, build out a menu that allows the user to choose whether they wish to convert Celsius to Fahrenheit or Fahrenheit to Celsius. Remember, you’ll want to capture the user’s input, and then utilize the two pieces of functionality you built (steps a, b) to show the result. 

4.Finally, extend the functionality to ask the user if they have another conversion once you have shown them their initial result. Reload the menu if they choose yes.Example Reference: InputLab.cs class in _3Wednesday & LoopingDoWhile.cs class in _5Friday. 

LOGINClass: Login.cs1.Ask the user for their username  
2.If it matches your one hard-coded, correct username, tell the user that they have access. If not, tell the user that they have been denied access. 3.Make sure the usernames (hard-coded & user input) are case insensitive (uppercase or lowercase)

ADDITIONAL FUNCTIONALITY:After the above default functionality is completed:4.Encase the username functionality in a loop that allows the user to make another attempt if the previous attempt was unsuccessful. 5.Extend the loop functionality to deny access to the user if they enter the wrong username 3 times.  6.Extend updated username functionality to ask for a password if the user entered the correct username. Deny access if the password is entered incorrectly 3 times. (Note: 3 attempts at username, if the correct username is entered, give 3 attempts for the correct password.)Example Reference: InputLab.cs class in _3Wednesday, BranchingIf.cs class or BranchingSwitch.cs class in _4Thursday, LogicComparison.cs class in _3Wednesday, and Looping classes in _5Friday. 

ATM Class: ATM.cs When thinking about how to structure this application, break it down into smaller problems. Every programming application is just a bunch of small problems put together into one larger solution. Look at what each requirement is asking from you. Start small - think about what you’ve learned that can solve that one problem (i.e. branching, looping, parsing, etc.), then build for that problem and integrate it into the application. Looking at the overall requirements, think about, “What can I do first? What do I need to happen as soon as the application runs? What after that?” and continue to evaluate each step before you code it. Consider how a real ATM works and the order that events occur.  

1.Write a program that will:    
a.Ask the user to enter an account number for their account  i.Continue to ask the user for their account number until they get it right (the correct account number will be hard coded in your code. See the Login section for an example). Optionally, consider locking them out after a certain number of failed attempts.  
b.Once they get the correct account number, ask them for a pin number (you can use the additional Login functionality as a reference). Just as you did for their account number, continue to prompt the user for their pin until they get it correct. (The correct value will be hard coded just as it was for the account number)  
c.Once the user has successfully given their account and pin numbers, prompt the user with a menu and ask them if they want to do a deposit, a withdrawal, or exit the application.  
d.If they choose to do a deposit, ask them for the amount to deposit, and display the amount deposited.  i.Ex. “$500.00 has been deposited into account number 12345” 
e.If they choose to withdraw money, ask them for the amount to withdraw and display the amount withdraw.   i.Ex. “$500.00 has been withdrawn from account number 12345” 
f.After each transaction (deposit or withdrawl), ask the user if they want to do another deposit, withdraw, or exit the application.  
g.When the user exits the application, thank them for their business. Additional Optional Features:•Keep a running total of the account balance, assuming that the account starts at $0.  •Every time the user makes a deposit to - or withdraw from - the account, the balance should be updated and displayed.    •Add a feature for the user to make a balance request that will display their current balance (without needing to make a deposit or withdrawal).Example References: InputLab.cs class in _3Wednesday, BranchingIf.cs class or BranchingSwitch.cs class in _4Thursday, and LogicComparison.cs class in _3Wednesday.  

SECTION 3: Real-World Coding Challenges (Bonus Content) The additional below problems are real-world coding challenges that will help you to expand your problem-solving abilities. You are also likely to see coding challenges such as these in code screens (used to get an idea of a job applicant’s coding ability). The below content is optional.

FIZZBUZZClass: FizzBuzz.csWrite a program that counts up from 1 to a number that the user enters. Any time a number divisible by three would display, print the word “Fizz” instead. Any time you would normally display a number that is divisible by 5, instead display the word “Buzz”.  Any time you would normally display a number that is divisible by both 3 and 5, display “FizzBuzz”.Output Example: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzzExample Reference: InputLab.cs class in _3Wednesday, Operators.cs class in _2Tuesday, & LoopingFor.cs class in _5Friday

FIBONACCI Class: Fibonacci.csWrite a program that outputs a Fibonacci sequence, starting at 1, until a number that the user inputs is reached. (If you unfamiliar with what a Fibonacci sequence is, do a Google search).Example Reference: Variable.cs class in _1Monday, InputLab.cs class in _3Wednesday, Operators.cs class in _2Tuesday, & LoopingWhile.cs class in _5Friday
