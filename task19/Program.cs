// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number!");


void CheckPalindrom(int num){
    int rev,sum=0,temp;
    temp = num;

    while (num > 0){
        rev = num % 10;
        sum = (sum*10)+rev;
        num = num/10;
    }
    if (temp == sum) {
        Console.WriteLine("Palindom");
    }
    else
    {
        Console.WriteLine("Non palindom");       
    }
}


int number = Convert.ToInt32(Console.ReadLine());

CheckPalindrom(number);
