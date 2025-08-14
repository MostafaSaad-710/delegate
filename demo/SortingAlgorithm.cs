using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public delegate bool  SortingFuncDelegate<T>(T A, T B);
    //public delegate bool SortingFuncDelegateS(string A, string B);



    internal class SortingAlgorithm
    {
        public static void BubbleSort<T>(T[] Arr ,Func<T,T,bool> /*SortingFuncDelegate<T>*/ reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j] , Arr[j+1]) )
                            SWAP(ref Arr[j] ,ref Arr[j + 1]);
                    }
                }
            }
        }
      
        public static void SWAP<T>(ref T X ,ref T Y)
        {
            T Tamp = X;
            X = Y;
            Y = Tamp;
        }
    }
}
