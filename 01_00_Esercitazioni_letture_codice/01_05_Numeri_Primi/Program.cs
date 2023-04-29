/***********************************************************************************************************************
 // Leggere il seguente codice e descrivere cosa fa il metodo:                                                          *
 ***********************************************************************************************************************/

public bool IsPrime(int n)
{
    if (n <= 1)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }

    return true;
}

//il metodo verifica se un numero intero "n" passato come parametro è un numero primo,
//utilizzando un ciclo "for" per controllare se "n" è divisibile per ogni numero compreso tra 2 e la radice quadrata di "n".
