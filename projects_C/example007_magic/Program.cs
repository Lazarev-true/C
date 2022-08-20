int xa = 25, ya = 1,
    xb = 1, yb = 18,
    xc = 50, yc = 18;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int i = 0;

while(i < 2000)
{
    int z = new Random().Next(0, 3);
    if(z == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(z == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(z == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    i++;
}