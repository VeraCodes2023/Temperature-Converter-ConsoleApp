# Temperature Converter

You are tasked to develop a temperature converter program in C#. The program will accept temperature values in Fahrenheit, Celsius, and convert them to their corresponding values in the other units.

## Requirements

1. Prompt the user to input a temperature value and a temperature scale (either Celsius or Fahrenheit).
2. Convert the temperature to the opposite scale and display the result.
3. Handle invalid user inputs by displaying an error message and prompting the user to enter valid inputs.
4. Write a function called `TempConvert` to perform the temperature conversions.
5. Use `switch` statement to determine which conversion function to use based on the user's input for the temperature scale.
6. Use type pattern in the `switch` statement to validate user's input.
7. Application should run continuously, but have option to terminate the program.
8. Rewrite `README` file and add your screenshots of testing application in your terminal.

## Examples

Your program does not need to look exactly like the example below, but should have similar features

````
Please enter a temperature value and its unit of measurement (F or C):
45 F
45 F = 7.22 C

Please enter a temperature value and its unit of measurement (F or C):
input C
Invalid input. Please enter a valid temperature value and its unit of measurement (F or C):

Please enter a temperature value and its unit of measurement (F or C):
30 X
Invalid input. Please enter a valid temperature value and its unit of measurement (F or C):

Please enter a temperature value and its unit of measurement (F or C):
exit
Program terminated.
````

## Screenshots of your output
![Alt text](image-2.png)
