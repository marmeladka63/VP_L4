﻿// Двумерные массивы респечатываем пустой.
string[,] table = new string[2,5];
table[1,2]="слово";

for (int rows=0; rows<2; rows++)
{
    for (int columns=0; columns<2; columns++)

{
    Console.WriteLine($"{table[rows,columns]}--");
}

}
