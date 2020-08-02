using System;
using System.Collections.Generic;
using System.Text;

namespace TiposOrdenamiento
{
    public class OrdenamientoHeap
    {
        private int dimension;

        private void construir(int[] arr)
        {
            dimension = arr.Length - 1;
            for (int i = dimension / 2; i >= 0; i--)
            {
                Heapify(arr, i);
            }
        }

        private void intercambiar(int[] arr, int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        private void Heapify(int[] arr, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest;

            if (left <= dimension && arr[left] > arr[index])
            {
                largest = left;
            }
            else
            {
                largest = index;
            }
            if (right <= dimension && arr[right] > arr[largest])
            {
                largest = right;
            }
            else
            {
                largest = index;
            }

            if (largest != index)
            {
                intercambiar(arr, index, largest);
                Heapify(arr, largest);
            }
        }
        public int[] OrdenarHeapInt(int[] arr)
        {
            construir(arr);
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                intercambiar(arr, 0, i);
                dimension--;
                Heapify(arr, 0);
            }
            return arr;
        }
    }
}
