﻿using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
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
        DataGeneric<string> nim = new DataGeneric<string>("103022330138");
        nim.PrintData();
    }
}
