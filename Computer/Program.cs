using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OperatingSystem { get; set; }

    public Computer(string ipAddress, int power, string os)
    {
        IPAddress = ipAddress;
        Power = power;
        OperatingSystem = os;
    }
}

// Клас Сервер
public class Server : Computer, IConnectable
{
    public Server(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
    }

    public void Connect(Computer target)
    {
        // Логіка підключення сервера до іншого комп'ютера
        Console.WriteLine($"Сервер {IPAddress} підключається до {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        // Логіка відключення сервера від іншого комп'ютера
        Console.WriteLine($"Сервер {IPAddress} відключається від {target.IPAddress}.");
    }

    public void TransmitData(Computer target, string data)
    {
        // Логіка передачі даних від сервера до іншого комп'ютера
        Console.WriteLine($"Сервер {IPAddress} передає дані до {target.IPAddress}: {data}");
    }
}

public class Workstation : Computer, IConnectable
{
    public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
    }

    public void Connect(Computer target)
    {
        // Логіка підключення робочої станції до іншого комп'ютера
        Console.WriteLine($"Робоча станція {IPAddress} підключається до {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        // Логіка відключення робочої станції від іншого комп'ютера
        Console.WriteLine($"Робоча станція {IPAddress} відключається від {target.IPAddress}.");
    }

    public void TransmitData(Computer target, string data)
    {
        // Логіка передачі даних від робочої станції до іншого комп'ютера
        Console.WriteLine($"Робоча станція {IPAddress} передає дані до {target.IPAddress}: {data}");
    }
}

public class Router : Computer, IConnectable
{
    public Router(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
    }

    public void Connect(Computer target)
    {
        // Логіка підключення маршрутизатора до іншого комп'ютера
        Console.WriteLine($"Маршрутизатор {IPAddress} підключається до {target.IPAddress}.");
    }

    public void Disconnect(Computer target)
    {
        // Логіка відключення маршрутизатора від іншого комп'ютера
        Console.WriteLine($"Маршрутизатор {IPAddress} відключається від {target.IPAddress}.");
    }

    public void TransmitData(Computer target, string data)
    {
        // Логіка передачі даних від маршрутизатора до іншого комп'ютера
        Console.WriteLine($"Маршрутизатор {IPAddress} передає дані до {target.IPAddress}: {data}");
    }
}

public interface IConnectable
{
    void Connect(Computer target);
    void Disconnect(Computer target);
    void TransmitData(Computer target, string data);
}

public class Network
{
    public void SimulateInteraction(IConnectable device1, IConnectable device2, string data)
    {
        // Моделюємо взаємодію між пристроями
        device1.Connect((Computer)device2);
        device1.TransmitData((Computer)device2, data);
        device1.Disconnect((Computer)device2);
    }
}

class Program
{
    static void Main()
    {
        var server = new Server("192.168.1.1", 1000, "Windows Server");
        var workstation = new Workstation("192.168.1.2", 500, "Windows 10");
        var router = new Router("192.168.1.3", 200, "RouterOS");

        var network = new Network();
        network.SimulateInteraction(server, workstation, "Hello, Workstation!");
        network.SimulateInteraction(workstation, router, "Hi, Router!");
        
        Console.ReadLine();
    }
}
