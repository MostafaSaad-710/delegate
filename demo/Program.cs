using System;
using System.Security.Principal;

namespace demo
{
    #region EX01
    //Step 01: Create New DataType (delegte)
    public delegate int StringFuncDelegate(string s);
    // New Delegate(Class) : Reference (pointer) Can Refere to functions or more (pointer of functions)
    // these functions must be have the same signature of the delegate : int (string)
    // Regardless(بغض النظر) Function Name , Parametars Name or, Access Modifier
     
    #endregion

    internal class Program
    {

        public static List<T> FindElements<T>(List<T> list, /*ConditionsFuncDelegate<T>*//*Predicate<T>*/Func<T,bool> reference)
        {
            List<T> Result = new List<T>();

            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        Result.Add(list[i]);
                    }
                }
            }

            return Result;
        }
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Delegate over view
            // Delegate : C# Feature

            // C# pure oop

            //Functional programming
            //Evant-driven programming

            //i can use desine pattern to achieve Fun Prog but C# have feture achieve it here name delegate

            #endregion

            #region delegate Ex01
            ////Step 02 : use delegate
            ////StringFuncDelegate X;
            ////X = StringFunctions.GetCountOfUpperCaseChars;

            ////StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars);
            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars;//sentax sugar
            //X += StringFunctions.GetCountOfLowerCaseChars; //= is reAssign so must use +=
            //                                               //+= Run Tow functions but too print(Lower) becouse var count holds only one value;


            ////int count = X.Invoke("Hello World");
            //int count = X("Hello World"); //Sentax Sugar
            //Console.WriteLine( count); 
            #endregion

            #region delegate Ex02 Without Generic

            //int[] numbers = { 1, 2, 3, 5, 6, 4, 7 };

            ////SortingAlgorithm.BubbleSortASC(numbers);
            ////PrintArray(numbers);

            ////Console.WriteLine( );

            ////SortingAlgorithm.BubbleSortDESC(numbers);
            ////PrintArray(numbers);

            ////SortingFuncDelegate X = SortingConditions.CompareGRT;
            ////SortingFuncDelegate<T> X = SortingConditions.CompareLess;

            ////SortingAlgorithm.BubbleSort(numbers , X);
            //SortingAlgorithm.BubbleSort(numbers, SortingConditions.CompareLess);
            //PrintArray(numbers);
            #endregion

            #region delegate Ex02 With Generic

            //string[] Names = { "Ahmed", "Ali", "mostafa", "Amr", "Mona", "Khaled" };

            ////SortingFuncDelegate X = SortingConditions.CompareGRTString;

            //SortingAlgorithm.BubbleSort(Names, SortingConditions.CompareGRT);
            //PrintArray(Names);

            #endregion

            #region delegate Ex03 With Generic
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            // List<int> OddNumbers = FindOddNumbers(Numbers);
            //List<int> EvenNumbers = FindEvenNumbers(Numbers);
            //List<int> DivisableBy4Numbers = FindDividableBy4Numbers(Numbers);

            //List<int> OddNumbers = FindElements(Numbers, ConditionsFunction.CheckOdd);
            //List<int> EvenNumbers = FindElements(Numbers, ConditionsFunction.CheckEven);
            //List<int> DivisableBy4Numbers = FindElements(Numbers, ConditionsFunction.CheckDivisableBy4);

            //PrintList(EvenNumbers);

            //List<string> Names = new List<string>() { "Ahmed", "Ali", "mostafa", "Amr", "Mona", "Khaled" };

            //List<string> Result = FindElements(Names, ConditionsFunction.CheckLengthGtr4);

            //PrintList(Result); 
            #endregion

            #region Built-in delegate

            //Built-in delegate

            // Predicate, Funs , Action

            //// Predicate - return bool and parametar T

            //Predicate<int> predicate = ConditionsFunction.CheckOdd;
            //bool r = predicate.Invoke(1);
            //Console.WriteLine( r);

            //// Func - return functions 

            //Func<int> func = Fun01;
            //Func<int, string> func1 = Fun02;
            //Func< int , bool > predicate = ConditionsFunction.CheckOdd;

            //Action - Void function

            //Action action = Print;
            //action.Invoke();
            //action();

            //Action<string> action = Print02;
            //action.Invoke("Hello");
            //action("Hello");

            #endregion

            #region Anonymous Method & lambda Expression

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////Func<int, bool> func = ConditionsFunction.CheckEven;

            ////Anonymous Method
            ////Func<int, bool> func = delegate (int X) { return X % 2 == 0; };//Anonymous Method

            //////List<int> num = FindElements(nums, func);
            ////List<int> num = FindElements(nums, delegate (int X) { return X % 2 == 0; });
            ////PrintList(num);


            ////lambda Expression [Recommended]

            //Func<int, bool> func = X => X % 2 == 0; //lambda Expression

            ////List<int> num = FindElements(nums, func);
            ////List<int> num = FindElements(nums, X => X % 2 == 0);
            //List<int> num = FindElements(nums, X => X % 2 != 0);
            //PrintList(num);

            #endregion

            #region Var

            //var X = 2;

            //var Y = ConditionsFunction.CheckDivisableBy4;

            #endregion

            #region Function returns Fuctions

            //var X = Fun01();
            //X.Invoke();

            //// or

            //Fun01()(); 

            #endregion

        }
        public static Action Fun01()
        {
            //Action action = Print;
            //Action action = delegate () { Console.WriteLine("Hello World"); };
            Action action = () => Console.WriteLine("Hello World");

            return action;

        }

        //public static void Print02(string x)
        //{
        //    Console.WriteLine(x);
        //}
        public static void Print()
        {
            Console.WriteLine("Hello World"); ;
        }
        //public static int Fun01()
        //{
        //    return 1;
        //}
        //public static string Fun02(int X)
        //{
        //    return $"{X}";
        //}
    }
}
