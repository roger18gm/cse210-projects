using System.Xml.Schema;

public class Room {

    private bool roomLights = false;
    private bool running = true;
    SmartHeater heater = new SmartHeater("iHeater 300x", false);
    SmartTv tv = new SmartTv("apple tv", false);

    List<SmartDevice> smartDevices;

    public Room(){
        smartDevices = new List<SmartDevice>{
            heater,
            tv
        };
    }

    public void MenuOptions(){
        while (running) {
                Console.Clear();
                Console.WriteLine("1. Want to turn on/off the lights?");
                Console.WriteLine("2. Want to turn on/off a device?");
                Console.WriteLine("3. Want to turn on/off all devices? ");
                Console.WriteLine("4. Display status of all items?");
                Console.WriteLine("5. Display items that are on?");
                Console.WriteLine("6. Display item that has been on the longest?");
                Console.WriteLine("7. Leave? ");

                string choice = Console.ReadLine();

                if (choice =="1") {
                    Console.Clear();
                    RoomLightsOnorOff();
                    Thread.Sleep(3000);
                }
                else if (choice=="2") {
                    Console.Clear();
                    Console.WriteLine("Select from the following: ");
                    int index = 1;

                    foreach (SmartDevice device in smartDevices) {
                        Console.WriteLine($"{index}. {device.GetDeviceName()}");
                        index ++;
                    }

                    string deviceChoice = Console.ReadLine();
                    if (int.Parse(deviceChoice) == index){
                        smartDevices[index-1].TurnOnorOff();
                        Thread.Sleep(3000);

                    }

                }
                else if (choice=="3") {
                    
                }
                else if (choice=="4") {
                    
                }
                else if (choice=="5") {
                    
                }
                else if (choice=="6") {
                    
                }
                else if (choice=="7") {
                    running = false;
                }
            }
    }

    public void RoomLightsOnorOff() {
        if (this.roomLights == true) {
            this.roomLights = false;
            Console.WriteLine("Lights are now off.");
        }

        else{
            this.roomLights = true;
            Console.WriteLine("Lights are now on.");

        }
    }
}