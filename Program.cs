// Числа фиббоначи f(1)=1 f(2)=1 f(n)=f(n-1)+f(n-2)*/

double Fibonnacci(int n)
{
    if (n==1||n==2) return 1;

    else return Fibonnacci(n-1) + Fibonnacci(n-2);
}

for (int i=1; i< 40; i++)
{
    Console.WriteLine(Fibonnacci(i));
}