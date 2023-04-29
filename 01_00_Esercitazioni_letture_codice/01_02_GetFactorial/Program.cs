/***********************************************************************************************************************
 * Leggere il seguente codice e descrivere cosa fa il metodo:                                                          *
 ***********************************************************************************************************************/
class Program
{
    static void Main(string[] args)   // metodo principale del programma
    {
        int GetFactorial(int n)
        {
            // Condizone if  se la variabile n è uguale a 0
            {
                if (n == 0)
                {
                    return 1;  // Se è vera restituisci valore 1      
                }
                else  // Se non si verifica calcola il fattoriale
                {

                    return n * GetFactorial(n - 1);
                }
            }
        }
    }
}
/*il metodo calcola il fattoriale di un numero intero "n" passato come parametro,
utilizzando una chiamata ricorsiva alla stessa funzione fino a quando il valore di "n" non diventa 0.
*/