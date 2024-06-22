using System.Net.WebSockets;

public class SmartHeater : SmartDevice {
    public SmartHeater(string deviceName, bool onStatus) : base(deviceName, onStatus) {

    }

    public override void CurrentStatus()
    {
        if (GetStatus() == true) {
            Console.WriteLine($"The {GetDeviceName} is on");}
            
        else{
            Console.WriteLine($"The {GetDeviceName} is off");

        }
    }

    
}