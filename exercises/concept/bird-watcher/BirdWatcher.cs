using System;

class BirdCount
{
    private int[] birdsPerDay;
    private static readonly int[] birdsPerDayLastWeek = { 0, 2, 5, 3, 7, 8, 4 };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() =>
        birdsPerDayLastWeek;

    public int Today() =>
        birdsPerDay[birdsPerDay.Length -1];

    public void IncrementTodaysCount() =>
        birdsPerDay[birdsPerDay.Length - 1]++;

    public bool HasDayWithoutBirds()
    {
        foreach(int dailyCount in birdsPerDay)
        {
            if (dailyCount == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for(int day=0; day<numberOfDays; day++)
        {
            total += birdsPerDay[day];
        }
        return total;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int dailyCount in birdsPerDay)
        {
            if (dailyCount >= 5) busyDays++;
        }
        return busyDays;
    }
}
