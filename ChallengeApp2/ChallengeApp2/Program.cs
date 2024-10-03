var number1 = 50;
var number2 = 10;

// operatory relacyjne
// == != > < <= >=

if (number1 < number2)
{
    Console.WriteLine("JESTEM TUTAJ W LINI 6");
}
else
{
    Console.WriteLine("JESTEM W LINI 10");
}


var name = "Adam";
var age = 33;

// operatory logiczne
// &&, ||, !

if (name == "Adam" &&  age < 50)
{
    Console.WriteLine("JESTEM ADAMEM PRZED 50");
} else
{
    Console.WriteLine("JESTEM KIMŚ INNYM");
}

if (name == "Adam" || age < 50)
{
    Console.WriteLine("JESTEM ADAMEM lub JESTEM PRZED 50");
}
else
{
    Console.WriteLine("JESTEM TUTAJ W LINI 37");
}

bool isTrue = true;
Console.WriteLine(isTrue);
isTrue = !isTrue;
Console.WriteLine(isTrue);

if (age > 50)
{
    if(name == "Adam")
    {
        Console.WriteLine("Jestem Adamem i mam więcej niż 50 lat");
    }
    else
    {
        Console.WriteLine("Więcej niż 50 lat");
    }
    
}
else if (age > 40)
{
    Console.WriteLine("Więcej niż 40 lat");
}
else if (age > 30)
{
    Console.WriteLine("Więcej niż 30 lat");
}
else
{
    Console.WriteLine("Więcej niż 20 lat");
}