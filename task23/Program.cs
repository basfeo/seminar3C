// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input Number");

int number = Convert.ToInt32(Console.ReadLine());


int CoubDigit(int digit){
    return (int)Math.Pow(digit,3);
}

for (int index = 1; index <= number; index++){
    Console.Write(CoubDigit(index)+ " ");
}