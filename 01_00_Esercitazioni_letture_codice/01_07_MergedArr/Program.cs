/***********************************************************************************************************************
 * Leggere il seguente codice e descrivere cosa fa il metodo:                                                          *
 ***********************************************************************************************************************/

public void MergeArrays(int[] arr1, int[] arr2)
{
    //
    int[] mergedArr = new int[arr1.Length + arr2.Length];
    int i = 0;
    int j = 0;
    int k = 0;

    while (i < arr1.Length && j < arr2.Length)
    {
        if (arr1[i] < arr2[j])
        {
            mergedArr[k] = arr1[i];
            i++;
        }
        else
        {
            mergedArr[k] = arr2[j];
            j++;
        }
        k++;
    }

    while (i < arr1.Length)
    {
        mergedArr[k] = arr1[i];
        i++;
        k++;
    }

    while (j < arr2.Length)
    {
        mergedArr[k] = arr2[j];
        j++;
        k++;
    }

    Console.WriteLine("Array merged:");
    foreach (int num in mergedArr)
    {
        Console.Write(num + " ");
    }
}


/*il metodo prende in input due array di numeri interi "arr1" e "arr2",
li unisce in un unico array ordinato "mergedArr" e stampa a video l'array risultante.
L'unione viene effettuata ordinando gli elementi degli array di partenza comparandoli tra loro per inserirli nell'array*/