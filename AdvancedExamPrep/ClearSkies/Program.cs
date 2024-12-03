

using System.Collections.Generic;
using System.Reflection;

int n = int.Parse(Console.ReadLine()); 

char[,] sky = new char[n, n];

int jetfighterRow = -1, jetfighterCol = -1;


int countEnemy = 0;
int armorValue = 300;
for (int i = 0; i < sky.GetLength(0); i++)
{
    string row = Console.ReadLine();
    for (global::System.Int32 j = 0; j < sky.GetLength(1); j++)
    {
        sky[i, j] = row[j];
        if (row[j] == 'J')
        {
            jetfighterRow = i; 
            jetfighterCol = j;
            sky[i, j] = '-';
        }
        else if (row[j] == 'E')
        {
            countEnemy++;
        }
    }
}

string commands = Console.ReadLine();
while (armorValue > 0 && countEnemy > 0)
{

    switch (commands)
    {
        case "up":

            jetfighterRow -= 1;

            break;

        case "down":

            jetfighterRow += 1;

            break;

        case "left":

            jetfighterCol -= 1;

            break;

        case "right":
            jetfighterCol += 1;

            break;

    }

    if (sky[jetfighterRow, jetfighterCol] == 'E')
    {
        if (countEnemy == 1)
        {
           
            sky[jetfighterRow, jetfighterCol] = 'J';
            countEnemy = 0;
            break;
        }
        else 
        {
            armorValue -= 100;
            sky[jetfighterRow, jetfighterCol] = '-';
            countEnemy--;
            if (armorValue == 0)
            {
                sky[jetfighterRow, jetfighterCol] = 'J';
                break; 
            }
        }
    }
    else if (sky[jetfighterRow, jetfighterCol] == 'R')
    {
        armorValue = 300;
        sky[jetfighterRow, jetfighterCol] = '-';
    }
    commands = Console.ReadLine();
}

if (armorValue == 0)
{
    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetfighterRow}, {jetfighterCol}]!");
}
else if (countEnemy == 0)
{
    Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
}

for (int i = 0; i < sky.GetLength(0); i++)
{
   
    for (global::System.Int32 j = 0; j < sky.GetLength(1); j++)
    {
        Console.Write(sky[i,j]);
    }
    Console.WriteLine();
}