using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic 13");
            System.Console.WriteLine(printSum(0,255));
            printArray(new int[] {1,2,3,4,5});
            System.Console.WriteLine(findMax(new int[] {5,6,77,8,9}));
            System.Console.WriteLine(findAvg(new int[] {456,654,214,1,2,0,-654}));
            System.Console.WriteLine(oddArray());
            System.Console.WriteLine(greaterY(new int[] {1,3,5,7}, 3));
            squareValues(new int[] {1,2,3,4,5});
            System.Console.WriteLine(eliminateNegativeNumbers(new int[] {-1,-2,-3}));
            minMaxAvg(new int[] {5,4,7,3,3,54,7});
            shiftValues(new int[] {5,4,7,3,3,54,7});
        }
        public static void printRange(int start,int end) {
            for (var i = start; i < end; i++) {
                System.Console.WriteLine(i);
            }
        }
        public static void printOddRange(int start,int end) {
            for (var i = start; i < end; i++) {
                if (i % 2 != 0) {
                    System.Console.WriteLine(i);
                }                
            }
        }
        public static int printSum(int start,int end) {
            int sum = 0;
            for (var i = start; i <= end; i++) {
                sum += i;
            }
            return sum;
        }
        public static void printArray(int[] arr) {
            foreach (int idx in arr) {
                System.Console.WriteLine(idx);
            }
        }
        public static int findMax(int[] arr) {
            var max = 0; 
            foreach (int idx in arr) {
                if (idx > max) {
                    max = idx;
                }
            }
            return max;
        }
        public static double findAvg(int[] arr) {
            double sum = 0;
            foreach (int idx in arr) {
                sum += idx;
            }
            double avg = sum/arr.Length;
            System.Console.WriteLine(sum);
            System.Console.WriteLine(arr.Length);
            return avg;
        }
        public static int[] oddArray() {
            int[] odd = new int[128];
            int i = 1;
            foreach (int idx in odd) {
                odd[idx] = i;
                i += 2;
            }
            return odd;
        }
        public static int greaterY(int[] arr, int y) {
            int count = 0;
            foreach (int idx in arr) {
                if (idx > y)
                {
                    count += 1;
                }
            }
            return count;
        }
        public static int[] squareValues(int[] arr) {
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
                System.Console.WriteLine(arr[i]);
            }
            return arr;
        }
        public static int[] eliminateNegativeNumbers(int[] arr) {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            return arr;
        }
        public static void minMaxAvg(int[] arr) {
            int min = arr[0];
            int max = arr[0];
            double avg = 0;
            double sum = 0;
            foreach (int idx in arr) {
                if (idx < min) {
                    min = idx;
                }
                if (idx > max) {
                    max = idx;
                }
                sum += idx;
            }
            avg = sum/arr.Length;
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(avg);
        }
        public static int[] shiftValues(int[] arr) {
        int[] newArr = new int[arr.Length];
        for (var i = 0; i < arr.Length-1; i++) {
            newArr[i] = arr[i+1];
            System.Console.WriteLine(newArr[i]);
        }
        newArr[arr.Length-1] = 0;
        return newArr;
        }
        public static object[] numberToString(object[] arr) {
            for (int idx = 0; idx < arr.Length; idx++) {
                if((int)arr[idx] < 0) {
                    arr[idx] = "Dojo";
                }
            }
            return arr;
        }
    }
}
