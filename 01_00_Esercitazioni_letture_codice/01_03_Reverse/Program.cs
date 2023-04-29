/***********************************************************************************************************************
 * Leggere il seguente codice e descrivere cosa fa il metodo:                                                          *
 ***********************************************************************************************************************/

public string ReverseString(string str)   
{
    //
    char[] charArray = str.ToCharArray();   
    Array.Reverse(charArray);
    return new string(charArray);
}


//il metodo prende in input una stringa e restituisce la stessa stringa ma con i caratteri in ordine inverso.
