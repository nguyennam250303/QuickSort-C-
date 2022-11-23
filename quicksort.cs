using System;
using System.Text;


namespace program
{
    class program
    {
        static void quickSort(List<int> arr, int left, int right)
        {
            if(left > right)
            {
                return;
            }    
            int key = arr[left];
            int l = left + 1;
            int r = right;
            int temp = 0; 
            while (l < r)
            {
                while (l < arr.Count() && arr[l] <= key)
                {
                    l++;
                }
                while (r > 0 && arr[r] > key)
                {
                    r--;
                }
                if (l < r)
                {
                    temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                }
            }
            if (arr[r] < key)
            {
                temp = arr[r];
                arr[r] = arr[left];
                arr[left] = temp;
            }
            quickSort(arr, left, r - 1);
            quickSort(arr, r + 1, right);
        }
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 2, 9 ,4 ,7 ,3,5,3,2 };
            quickSort(a, 0, a.Count() - 1);
            foreach (int val in a)
                Console.Write(val + " ");

        }
    }
}














