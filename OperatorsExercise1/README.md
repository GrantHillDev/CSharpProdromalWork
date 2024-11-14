## Exercise 1:

+ Create a simple program using the template to write out the results of addition, subtraction, multiplication, division, and modulus operations.

+ For division, create two integer variables called a and b.

+ Create a third integer variable and name it quotient (the result of a division) that stores the result of the division of a and b, and another integer variable named remainder that stores the remainder (using the % operator). Write out the results using Console.WriteLine or Console.Write to write out the results in the following form: if a = 17 and b = 4, print the following:

  The result should say: 17/4 is 4 remainder 1

## Exercise 2:

+ Create a method that will Calculate the area of a circle based on its radius - you can name the method AreaOfCircle.

+ This method will use this formula Math.PI * Math.Pow(radius, 2) and return the area of type double

+ The method will also accept radius as a parameter

+ Allow a user to input a value for radius in the console using the following code:

```
var radius = double.Parse(Console.ReadLine());
```

When finished your output should look something like this:

```
17/4 is 4 remainder 1
what is the radius of your circle?
20
The area of a circle with radius of 20 is 1256.6370614359173
press any key to continue...
```
## Thought Exercise:

What is the value of k in the following code?:
```
// var is implicit type inferrence (more on this later)
var i = 3;
var j = 4;
var k = ++i * j++;

Console.WriteLine(k); // ouputs ?
```
