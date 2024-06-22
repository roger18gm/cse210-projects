public abstract class SmartDevice
{
    private string deviceName;

    private bool onStatus = false;

    public SmartDevice(string deviceName, bool onStatus){
        this.deviceName = deviceName;
        this.onStatus = onStatus;
    }

    public void TurnOnorOff() {
        if (GetStatus() == true) {
            SetStatus(false);
            Console.WriteLine($"The {GetDeviceName} is now off");
            }

        else{
            SetStatus(true);
            Console.WriteLine($"The {GetDeviceName} is now on");

        }
    }
    public abstract void CurrentStatus();

    public bool GetStatus(){
        return this.onStatus;
    }

    public void SetStatus(bool value){
        this.onStatus = value;
    }

    public string GetDeviceName(){
        return this.deviceName;
    }
    }