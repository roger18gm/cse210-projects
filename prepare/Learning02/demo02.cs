using System;

class ProgramOne
{
    static void MainOne(string[] args)
    {
        Person fred = new Person("Fred", "Flinstone");

        Person steve = new Person("Steve", "Minecraft");


        fred.EasternStyleName();
        steve.EasternStyleName();

    }
}