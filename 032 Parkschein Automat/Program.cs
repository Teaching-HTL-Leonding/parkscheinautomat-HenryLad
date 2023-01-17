string Coins;
int hour = 0;
int minute = 0;
double donationmin = 0;
double dontionhour = 0;

void WelcomeMessage()
{
    System.Console.WriteLine("Parkschein Automat mit Mindespark dauer von 30 Minuten und maximal Parkdauer von 1 : 30 Stunden ");
    System.Console.WriteLine("Tarif pro Stunde : 1 Euro ");
    System.Console.WriteLine("Akzeptiere Münzen : 5 cent, 10 cent, 20 cent, 50 cent, 1 Euro, 2 Euro ");
    System.Console.WriteLine("Schreibe [D] um das Programm zu benden");
}
void EnterCoins()
{
    do{
    System.Console.WriteLine($"Parkzeit bisher:{hour} : {minute}");
    
    System.Console.Write("Your entry : ");
    Coins = (System.Console.ReadLine()!);
    if(hour == 0 && minute == 0 && Coins == "D"){System.Console.WriteLine("You have no money on your park Ticket");}
    switch (Coins)
    {
        case "d":
        
        break;
        case "5":
        minute += 3; if(minute > 60){minute -= 60; hour += 1;}
        break;
        case "10":
        minute += 6; if(minute > 60){minute -= 60; hour +=1;}
        break;
        case "20":
        minute += 12; if(minute > 60){minute -= 60; hour +=1;}
        break;
        case "50":
        minute += 30; if(minute > 60){minute -= 60; hour +=1;}
        break;
        case "1":
        hour += 1; if(minute > 60){minute -= 60; hour +=1;}
        break;
        case "2":
        hour += 2; if(minute > 60){minute -= 60; hour += 1;}
        break;
    }
       

    }while(Coins != "d");
    }

void PrintParkingTime(){System.Console.WriteLine($"You can park for {hour} hour and {minute} minutes");}
void Donation()
{
    if(hour >= 1 && minute >= 30 ){hour -= 1; minute -= 30;
    while(hour != 0)
    {
        hour--;
        minute += 60;

    }
    while(minute != 0)
    {
        minute--;
        donationmin += 0.6 ;
        if(donationmin >= 60)
        {
            donationmin -= 60;
            dontionhour += 1;
        }
        
        
    }
    System.Console.WriteLine($"Thank you for your donation of {dontionhour} Euro : {donationmin} Cents");
    }}
WelcomeMessage();
EnterCoins();
PrintParkingTime();
Donation();