public class work
{
    int isPartTime = 2;
    int isFullTime = 1;
    int ratePerHr = 60;
    int numWorkingDays = 30;
    int empWrkHrs = 0;

    public void calWage()
    {
        Random num = new Random();
        int ran = num.Next(0, 3);

        if (ran == isPartTime)
        {
            Console.WriteLine("Is Part Time");
            empWrkHrs = 8;


        }
        else if (ran == isFullTime)
        {
            Console.WriteLine("Is Present");
            empWrkHrs = 16;


        }
        else
        {
            Console.WriteLine("Is Absent");
            empWrkHrs = 0;
        }
        //int empWage = empWrkHrs * ratePerHr;
        //int monthlyWage = empWage * numWorkingDays;

        //Console.WriteLine("The Daily salary is :" + empWage+" " + "The Monthly salary is :" + monthlyWage);
    }

    public void Full()
    {
        int empWage = empWrkHrs * ratePerHr;
        int monthlyWage = empWage * numWorkingDays;

        Console.WriteLine("The Daily salary is :" + empWage+" " + "The Monthly salary is :" + monthlyWage);
    }
}