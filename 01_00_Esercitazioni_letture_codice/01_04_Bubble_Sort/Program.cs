﻿public int[] BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr;
}


//il metodo implementa l'algoritmo di ordinamento "Bubble Sort" per un array di numeri interi "arr".
//L'algoritmo ordina l'array confrontando coppie di elementi adiacenti e scambiandoli se non sono in ordine crescente.
