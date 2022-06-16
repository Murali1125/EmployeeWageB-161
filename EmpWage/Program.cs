
const int DAILY_WAGE = 20, DAILY_HR = 8;
Random random = new Random();
int isEmppr = random.Next(0, 2);
if(isEmppr == 1)
{
    Console.WriteLine(" present");
    Console.WriteLine(DAILY_WAGE * DAILY_HR);
}
else
{
    Console.WriteLine(" abcent");
}
