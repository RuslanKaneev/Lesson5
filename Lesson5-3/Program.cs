// See https://aka.ms/new-console-template for more information
//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

int[] determiningTheNumberMassiv = new int[0];

void СonversionToNumbers(string enteringNumber)
{
    int savingNumber = 0;
    string savingSymbol= null;
    
    for (int i = 0; i < enteringNumber.Length; i++)
    {
        if (enteringNumber[i] != ' ')
        {
            savingSymbol += enteringNumber[i];
        }

        if (enteringNumber[i] == ' '|| i == enteringNumber.Length - 1)
        {   
            savingNumber = Convert.ToInt32(savingSymbol);
            int[] determiningTheNumber = determiningTheNumberMassiv;
            determiningTheNumberMassiv = new int[determiningTheNumber.Length + 1];

            for (int x = 0; x < determiningTheNumber.Length; x++)
            {
                determiningTheNumberMassiv[x] = determiningTheNumber[x];
            }
            determiningTheNumberMassiv[determiningTheNumberMassiv.Length-1] = savingNumber;

           savingSymbol = null;
           
        }

    }
  
}
Console.WriteLine("Введите через пробел произвольный набор чисел от 0 до 255");
СonversionToNumbers(Console.ReadLine());

NumberMassiv theNumberMassiv = new NumberMassiv();
theNumberMassiv.TheNumber = determiningTheNumberMassiv;
BinaryFormatter saveNumber = new BinaryFormatter();
saveNumber.Serialize(new FileStream("Binar.bin", FileMode.OpenOrCreate), theNumberMassiv);


[Serializable]
public class NumberMassiv
{
    private int[] _theNumber;

    public int[] TheNumber
    {
        get { return _theNumber; }
        set { _theNumber = value; }
    }
}





