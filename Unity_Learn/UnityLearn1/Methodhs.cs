using System;
using System.Collections.Generic;
using System.Text;

namespace UnityLearn
{
    class Methodhs
    {
        /*
        What are methods?
            -> methods are also called functions
            -> they execute blocks of the code that makes our game do thing 
            To achieve this we must:
                1.DECLARE and define our method
                2.CALL our method when we want it to execute 
        Examples:
            DECLARE method:
                 CleanYourRoom()
                        -> pick up clothes 
                        throw out garbage 
                        remove the mouldy pizza that threatens to mutate and destroy life as we know it
            CALL method :
                -> Mother: Hey ,go and CleanYourRoom()



        Code example 
                class addition{
                        void add(int a ,int b){   // DECLARIN method
                                sum = a + b;
                                Console.WriteLine("Result Add :" sum);
        }
        }
        }
                static void Main(string[]args){
                        addition call = new addition();
                        call.add(1,2); Call the methood by making a class 
        }

        =================
         DECLARE method
        =================
        void CleanYourRoom() //CleanYourRoom -> function name or give name what you want 
                             // give a meaning full name  what the function do 
                            // () -> parameters or arguments are required 
                            // parameters needs type and name (eg : int add,int time or int deadline,int score)
        {
            Things to do;
        }
        // void : return nothing 
        // static : used to declare the method without creating the object or when object is not required 
        // when void is not written then we have to return a value 
        // example :
                RETURN method or Function
                static int add(int a ,int b){
                    sum = a + b;
                    return sum;// type = int 
        }
                static void Main(string[]args){
                    result = demo.add(1,2);
                    Console.WriteLine("Sum of two numbers : " + result);
        }

        What about Start() and Upadte():
            they are predefined methodhs in unity 
            They are called by unity's internal logic is takong care of calling them for us at the right time 
            they are referred to as "callbacks"
            
         */

        /*
        /*
        =================================================
        METHODS (FUNCTIONS)
        =================================================

        What is a Method?

        A method is a block of code that performs a specific task.

        Methods are also called Functions.

        Instead of writing the same code again and again,
        we put it inside a method and call it whenever needed.

        Examples in Games:
        - MovePlayer()
        - Jump()
        - Shoot()
        - TakeDamage()
        - OpenDoor()

        Think of a method as a machine.

        Input ---> Method ---> Output

        Example:

        Numbers ---> Add() ---> Sum


        =================================================
        WHY USE METHODS?
        =================================================

        1. Reuse Code
           Write once, use many times.

        2. Better Organization
           Keeps code clean and readable.

        3. Easier Debugging
           Problems are easier to find.


        =================================================
        TWO STEPS OF USING METHODS
        =================================================

        1. DECLARE (Create) the method

        2. CALL (Use) the method


        Real Life Example:

        DECLARE:

        CleanYourRoom()
        {
            Pick up clothes
            Throw garbage
            Clean desk
        }

        CALL:

        Mother says:
        "Go CleanYourRoom()"

        Now the method executes.


        =================================================
        METHOD DECLARATION SYNTAX
        =================================================

        ReturnType MethodName(parameters)
        {
            Code Here
        }

        Example:

        void Jump()
        {
            // Jump code
        }


        =================================================
        PARTS OF A METHOD
        =================================================

        void Jump()
        {
        }

        void
        -----
        Return Type

        Jump
        -----
        Method Name

        ()
        -----
        Parameters

        {}
        -----
        Method Body


        =================================================
        METHOD NAME
        =================================================

        Give meaningful names.

        Good Examples:

        MovePlayer()
        Shoot()
        Jump()
        TakeDamage()

        Bad Examples:

        abc()
        xyz()
        test123()


        =================================================
        VOID
        =================================================

        void means:

        "This method returns nothing."

        Example:

        void SayHello()
        {
            Console.WriteLine("Hello");
        }

        The method does something,
        but it does NOT send a value back.


        =================================================
        PARAMETERS
        =================================================

        Parameters are values received by a method.

        Example:

        void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        Calling:

        PrintName("Dhruv");

        Here:

        string name

        is the parameter.


        =================================================
        MULTIPLE PARAMETERS
        =================================================

        void Add(int a, int b)
        {
        }

        a and b are parameters.

        Calling:

        Add(5, 10);


        =================================================
        METHOD WITH NO PARAMETERS
        =================================================

        void Jump()
        {
        }

        Calling:

        Jump();


        =================================================
        METHOD CALLING
        =================================================

        Creating the method:

        void Shoot()
        {
            Console.WriteLine("Bang!");
        }

        Calling the method:

        Shoot();

        Output:

        Bang!


        =================================================
        RETURN
        =================================================

        Sometimes we want a method to give back a value.

        For that we use return.

        Example:

        int Add(int a, int b)
        {
            int sum = a + b;

            return sum;
        }

        The method sends the value back.


        =================================================
        RETURN TYPE
        =================================================

        int Add()
        {
            return 5;
        }

        int
        ---
        The method must return an integer.


        string GetName()
        {
            return "Dhruv";
        }

        string
        ------
        The method must return text.


        float GetSpeed()
        {
            return 10.5f;
        }

        float
        -----
        The method must return a decimal number.


        =================================================
        COMPLETE EXAMPLE
        =================================================

        class Addition
        {
            public int Add(int a, int b)
            {
                int sum = a + b;

                return sum;
            }
        }

        static void Main(string[] args)
        {
            Addition calculator = new Addition();

            int result = calculator.Add(10, 20);

            Console.WriteLine("Sum = " + result);
        }

        Output:

        Sum = 30


        =================================================
        STATIC METHOD
        =================================================

        Normally:

        Addition calculator = new Addition();

        calculator.Add(10,20);

        We first create an object.


        Static methods do not need an object.

        Example:

        class Demo
        {
            public static void Hello()
            {
                Console.WriteLine("Hello");
            }
        }

        Calling:

        Demo.Hello();

        Output:

        Hello


        =================================================
        WHEN TO USE STATIC?
        =================================================

        Use static when:

        - No object data is needed.
        - Utility functions.
        - Helper methods.
        - Mathematical calculations.

        Examples:

        Math.Sqrt()
        Math.Pow()
        Math.Abs()


        =================================================
        MEMORY TRICK
        =================================================

        Method = A task

        void = Returns nothing

        return = Sends a value back

        parameter = Input received

        argument = Actual value passed

        call = Execute the method

        static = Use method without creating object


        Example:

        Add(5,10)

        5 and 10 -> Arguments

        int a, int b -> Parameters
        */
    }
}
