//Pinger

using System.Net.NetworkInformation;

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8"); //8.8.8.8 ip adress do google


while (PR.Status.ToString() == "Success")
{
    Console.WriteLine(PR.Status.ToString() + "!");
    PR = p1.Send("8.8.8.8");
    Console.WriteLine("Wainting ten seconds for next request");
    Thread.Sleep(10000);
}