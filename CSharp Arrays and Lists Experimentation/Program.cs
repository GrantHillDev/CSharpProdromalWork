using System;
using System.Collections.Generic;

namespace CSharp_Arrays_and_Lists_Experimentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            explicitlyTypedArray1();//implicitlyTypedArray1();
            explicitlyTypedArray2();//implicitlyTypedArray2();
            explicitlyTypedArray3();//implicitlyTypedArray3();
            inferredTypedArray1();
            inferredTypedArray2();
            inferredTypedArray3();
            explicitlyTypedList1();//implicitlyTypedList1();
        }
        public static void explicitlyTypedArray1()//implicitlyTypedArray1()//remember that this method is called only once in the main method, and will therefore only execute once, as per its own instruction.... whereas if it were given a means to run more than once, and we use a variable to act as a counter or tracker for how many times this has occurred, then the use of breakpoints can be witnessed. Otherwise, just print to console what the script is doing.
        {
            int[] impArray1 = new int[7];//an implicitly typed array has been crafted here into a variable -- remember that its size cannot change once initialized, and neither can its type.
            //Console.WriteLine($"{impArray1}");//this doesn't print each value that's contained within the array we've created.
            foreach (int i in impArray1)//here, we're telling the computer that we want it to do something for each value it has stored within our array.
            {
                Console.WriteLine(i);//now, we can print these stored values to the console. In this case, no values were ever assigned within this array, so the yields are all zeroes for each of its seven slots.
            }
            Console.WriteLine("");//placing the Console.WriteLine(""); function down here allows for there to only be one space between this methods console print and the next one's -- provided more than one method in this whole program is being run at the same time.
        }
        public static void explicitlyTypedArray2()//implicitlyTypedArray2()
        {
            int[] impArray2 = new int[7];
            impArray2[0] = 7;//this is one way in which we can assign each slot of an array to a value.
            impArray2[1] = 7;
            impArray2[2] = 7;
            impArray2[3] = 7;
            impArray2[4] = 7;
            impArray2[5] = 7;
            impArray2[6] = 7;
            foreach (int l in impArray2)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("");
        }
        public static void explicitlyTypedArray3()//implicitlyTypedArray3()
        {//be advised that VS Community will throw an error at you during code writing if you fail to assign a value to each of its slots when utilizing the slot value assignment strategy shown below.
            int[] impArray3 = new int[7] { 44, 81, 57, 64, 83, 33, 77 };//this is a much more efficient way in which we can assign each slot of our array.
            foreach (int p in impArray3)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("");
            Console.WriteLine(impArray3.Length);//Arrays have this property, 'Length', that can be printed to the console, just like in this instance.
            Console.WriteLine(impArray3.Length - 1);
            Console.WriteLine("");
        }
        public static void inferredTypedArray1()
        {
            //var infArray1 = new int[];//all arrays must have a size determined or initialized before creating an instance of them.
            var infArray1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            for (int i = 0; i < infArray1.Length; i++)//here, the value of variable i is changing each time this script executes, which consequently enables it to change which slot it is currently accessing, and then printing it to the console, we can see all slots that i accesses, as a consequence of the script executing over and over again. Not a bad way to print an array, but it's better if certain slots need to presented in a certain order; something which the foreach function cannot do.
            {
                Console.WriteLine(infArray1[i]);
            }
            Console.WriteLine("");
        }
        public static void inferredTypedArray2()
        {
            var infArray2 = new string[] { "Centurion", "Arcanis", "Selene", "Magnus", "Isabelle", "Cataclysm", "Malignity", "Draevourn" };
            for (int c = 0; c < infArray2.Length; c++)
            //for (int c = infArray2.Length; c > 0; c--)//for some reason this attempt didn't work, even though it made logical sense to me (index was outside the bounds of the array).
            //for (int c = infArray2.Length-1; c >= 0; c--)//this actually fixes the problem experienced per the specific error thrown at me for the above line of code -- have to remember that the first slow operates on a value of zero, not 1.
            {
                Console.WriteLine(infArray2[c]);
            }
            Console.WriteLine("");
        }
        public static void inferredTypedArray3()//when we use conditions/conditionals, it's important to remember how the script you write 'thinks' -- when we declare and initialize a variable in a for loop, as an example, say 'i', i cannot be equal to something; it has to be written as though it were a comparison to something else (say a value). This is because the computer is asking every time it runs that code, is 'i' greater than, less than whatever its conditional is. If 'i' is equal to a value, it's not exactly being evaluated in the right context based on its own scripting.
        {
            var infArray3 = new string[] { "Centurion", "Arcanis", "Selene", "Magnus", "Isabelle", "Cataclysm", "Malignity", "Draevourn" };//try the previous method, but in backwards order.
            for (int f = 7; f >= 0; f--)//run until variable f hits a value of zero. Making the condition set to >= 0 enables the information contained within the array's first slot to be accessed by the script. If it's > 0, slot1 in this array won't be accessed. a value of -1 has to be added to the infArray3.Length because it needs to be equated to a value that is at least one number less than what it is, because it starts at a value of zero for its first slot. So, equating it to a value of 8 in this case throws an error.
            {
                Console.WriteLine(infArray3[f]);
            }
            Console.WriteLine("");
        }
        public static void explicitlyTypedList1()//implicitlyTypedList1()//lists don't need to have their size declared before implementing instances of them, unlike arrays.
        {
            List<int> impList1 = new List<int>();
            foreach (int a in impList1)
            {
                Console.WriteLine(a);//this doesn't print anything to the console when executed, and I'm guessing it's because its size was never determined.... so it won't even print a single zero.
            }
            Console.WriteLine("");
        }
        public static void explicitlyTypeList2()//implicitlyTypedList2()
        {
            List<int> impList2 = new List<int>();
            foreach (int b in impList2)
            {
                Console.WriteLine(b);
            }
        }
    }
}
