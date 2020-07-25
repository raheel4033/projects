using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DS
{
    interface quickSort
    {
        int Partition(int[] input, int left, int right);
       
        void QuickSort(int[] input, int left, int right);

    }
}
