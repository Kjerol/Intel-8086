using System;

namespace arch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zawartość rejestru AX: ");
            string AX = Console.ReadLine();
            Console.WriteLine("Podaj zawartość rejestru BX: ");
            string BX = Console.ReadLine();
            Console.WriteLine("Podaj zawartość rejestru CX: ");
            string CX = Console.ReadLine();
            Console.WriteLine("Podaj zawartość rejestru DX: ");
            string DX = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("1.MOV \n2.XCHNG");
            string co = Console.ReadLine();
            Console.WriteLine();

            if (co == "MOV")
            {
                while (true)
                {
                    Console.WriteLine("Podaj pierwszy rejestr rozkazu MOV: ");
                    string pierwszy = Console.ReadLine();
                    Console.WriteLine("Podaj drugi rejestr rozkazu MOV: ");
                    string drugi = Console.ReadLine();
                    Console.WriteLine();

                    if (pierwszy == "AX" && drugi == "AX")
                    {
                        AX = AX;
                    }
                    else if (pierwszy == "AX" && drugi == "BX")
                    {
                        AX = BX;
                    }
                    else if (pierwszy == "AX" && drugi == "CX")
                    {
                        AX = CX;
                    }
                    else if (pierwszy == "AX" && drugi == "DX")
                    {
                        AX = DX;
                    }
                    else if (pierwszy == "BX" && drugi == "AX")
                    {
                        BX = AX;
                    }
                    else if (pierwszy == "BX" && drugi == "BX")
                    {
                        BX = BX;
                    }
                    else if (pierwszy == "BX" && drugi == "CX")
                    {
                        BX = CX;
                    }
                    else if (pierwszy == "BX" && drugi == "DX")
                    {
                        BX = DX;
                    }
                    else if (pierwszy == "CX" && drugi == "AX")
                    {
                        CX = AX;
                    }
                    else if (pierwszy == "CX" && drugi == "BX")
                    {
                        CX = BX;
                    }
                    else if (pierwszy == "CX" && drugi == "CX")
                    {
                        CX = CX;
                    }
                    else if (pierwszy == "CX" && drugi == "DX")
                    {
                        CX = DX;
                    }
                    else if (pierwszy == "DX" && drugi == "AX")
                    {
                        DX = AX;
                    }
                    else if (pierwszy == "DX" && drugi == "BX")
                    {
                        DX = BX;
                    }
                    else if (pierwszy == "DX" && drugi == "CX")
                    {
                        DX = CX;
                    }
                    else if (pierwszy == "DX" && drugi == "DX")
                    {
                        DX = DX;
                    }
                    else
                    {
                        Console.WriteLine("Błędnie podano rejestry procesora");
                    }

                    Console.WriteLine("Aktualny stan rejestrów procesora po wykonaniu rozkazu MOV: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");
                    Console.WriteLine();
                }
            }
            else if (co == "XCHNG")
            {
                while (true)
                {
                    string AXC = AX;
                    string BXC = BX;
                    string CXC = CX;
                    string DXC = DX;
                    Console.WriteLine("Podaj pierwszy rejestr rozkazu XCHNG: ");
                    string pierwszy = Console.ReadLine();
                    Console.WriteLine("Podaj drugi rejestr rozkazu XCHNG: ");

                    string drugi = Console.ReadLine();
                    Console.WriteLine();

                    if (pierwszy == "AX" && drugi == "AX")
                    {
                        AX = AXC;
                        AX = AXC;
                    }
                    else if (pierwszy == "AX" && drugi == "BX")
                    {
                        AX = BXC;
                        BX = AXC;
                    }
                    else if (pierwszy == "AX" && drugi == "CX")
                    {
                        AX = CXC;
                        CX = AXC;
                    }
                    else if (pierwszy == "AX" && drugi == "DX")
                    {
                        AX = DXC;
                        DX = AXC;

                    }
                    else if (pierwszy == "BX" && drugi == "AX")
                    {
                        BX = AXC;
                        AX = BXC;
                    }
                    else if (pierwszy == "BX" && drugi == "BX")
                    {
                        BX = BXC;
                        BX = BXC;
                    }
                    else if (pierwszy == "BX" && drugi == "CX")
                    {
                        BX = CXC;
                        CX = BXC;
                    }
                    else if (pierwszy == "BX" && drugi == "DX")
                    {
                        BX = DXC;
                        DX = BXC;
                    }
                    else if (pierwszy == "CX" && drugi == "AX")
                    {
                        CX = AXC;
                        AX = CXC;
                    }
                    else if (pierwszy == "CX" && drugi == "BX")
                    {
                        CX = BXC;
                        BX = CXC;
                    }
                    else if (pierwszy == "CX" && drugi == "CX")
                    {
                        CX = CXC;
                        CX = CXC;
                    }
                    else if (pierwszy == "CX" && drugi == "DX")
                    {
                        CX = DXC;
                        DX = CXC;
                    }
                    else if (pierwszy == "DX" && drugi == "AX")
                    {
                        DX = AXC;
                        AX = DXC;
                    }
                    else if (pierwszy == "DX" && drugi == "BX")
                    {
                        DX = BXC;
                        BX = DXC;
                    }
                    else if (pierwszy == "DX" && drugi == "CX")
                    {
                        DX = CXC;
                        CX = DXC;
                    }
                    else if (pierwszy == "DX" && drugi == "DX")
                    {
                        DX = DXC;
                        DX = DXC;
                    }
                    else
                    {
                        Console.WriteLine("Błędnie podano rejestry procesora");
                    }
                    Console.WriteLine("Aktualny stan rejestrów procesora po wykonaniu rozkazu MOV: ");
                    Console.WriteLine($"AX: {AX}");
                    Console.WriteLine($"BX: {BX}");
                    Console.WriteLine($"CX: {CX}");
                    Console.WriteLine($"DX: {DX}");
                }
            }
        }
    }
}
