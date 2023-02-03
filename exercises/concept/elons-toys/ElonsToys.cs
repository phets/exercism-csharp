using System;

class RemoteControlCar
{
    private int _distanceDriven = 0, _battteryRemaining = 100;
    public static RemoteControlCar Buy() =>
        new RemoteControlCar();

    public string DistanceDisplay() =>
        $"Driven {_distanceDriven} meters";

    public string BatteryDisplay() =>
        (_battteryRemaining > 0) ? $"Battery at {_battteryRemaining}%" : "Battery empty";

    public void Drive()
    {
        if(_battteryRemaining> 0)
        {
            _battteryRemaining--;
            _distanceDriven += 20;
        }
    }
}
