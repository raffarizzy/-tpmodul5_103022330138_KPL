﻿using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
    static void Main()
    {
        HaloGeneric gen = new HaloGeneric();
        gen.SapaUser("Raffa");
    }
}
