using System;

class Phone
{
    public string number;
    public string model;
    public double weight;

    public Phone(string number, string model, double weight)
    {
        this.number = number;
        this.model = model;
        this.weight = weight;
    }

    public Phone(string number, string model) : this(number, model, 0)
    {
    }

    public Phone() : this("undefined", "undefined", 0)
    {
    }

    public void receiveCall(string callerName)
    {
        Console.WriteLine($"Call {callerName}");
    }

    public string getNumber()
    {
        return number;
    }

    public void receiveCall(string callerName, string callerNumber)
    {
        Console.WriteLine($"Call {callerName}, phone number: {callerNumber}");
    }

    public void sendMessage(params string[] phoneNumbers)
    {
        Console.WriteLine("Send message to:");
        foreach (string number in phoneNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

class CreditCard
{
    public string accountNumber;
    public double currentBalance;

    public void AddAmount(double amount)
    {
        currentBalance += amount;
    }

    public void WithdrawAmount(double amount)
    {
        if (currentBalance >= amount)
        {
            currentBalance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds in the account.");
        }
    }

    public void PrintCardInfo()
    {
        Console.WriteLine($"Account number: {accountNumber}");
        Console.WriteLine($"Current balance: {currentBalance}");
    }
}

class ATM
{
    private int NumberOf20Bills;
    private int NumberOf50Bills;
    private int NumberOf100Bills;

    public ATM(int num20Bills, int num50Bills, int num100Bills)
    {
        NumberOf20Bills = num20Bills;
        NumberOf50Bills = num50Bills;
        NumberOf100Bills = num100Bills;
    }

    public void AddMoney(int num20Bills, int num50Bills, int num100Bills)
    {
        NumberOf20Bills += num20Bills;
        NumberOf50Bills += num50Bills;
        NumberOf100Bills += num100Bills;
    }

    public bool WithdrawMoney(int amount)
    {
        int remainingAmount = amount;
        int count100 = Math.Min(remainingAmount / 100, NumberOf100Bills);
        remainingAmount -= count100 * 100;

        int count50 = Math.Min(remainingAmount / 50, NumberOf50Bills);
        remainingAmount -= count50 * 50;

        int count20 = Math.Min(remainingAmount / 20, NumberOf20Bills);
        remainingAmount -= count20 * 20;

        if (remainingAmount == 0)
        {
            Console.WriteLine($"100 banknotes were issued: {count100}");
            Console.WriteLine($"50 banknotes were issued: {count50}");
            Console.WriteLine($"20 banknotes were issued: {count20}");

            NumberOf100Bills -= count100;
            NumberOf50Bills -= count50;
            NumberOf20Bills -= count20;

            return true;
        }
        else
        {
            Console.WriteLine("There are not enough bills to issue the requested amount.");
            return false;
        }
    }
}

class Doctor
{
    public string Name { get; set; }

    public Doctor(string name)
    {
        Name = name;
    }

    public void Treat()
    {
        Console.WriteLine($"The doctor {Name} treats the patient.");
    }
}

class Patient
{
    public string Name { get; set; }
    public int TreatmentPlan { get; set; }

    public Patient(string name, int treatmentPlan)
    {
        Name = name;
        TreatmentPlan = treatmentPlan;
    }

    public void AssignDoctor(Doctor doctor)
    {
        switch (TreatmentPlan)
        {
            case 1:
                Console.WriteLine($"The patient {Name} has been assigned a surgeon.");
                doctor.Treat();
                break;
            case 2:
                Console.WriteLine($"The patient {Name} has been assigned a dentist.");
                doctor.Treat();
                break;
            default:
                Console.WriteLine($"The patient {Name} has been assigned a therapist.");
                doctor.Treat();
                break;
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the task number to check: ");
        int task;
        task = Convert.ToInt32(Console.ReadLine());
        switch (task)
        {
            case 1:
                Phone phone1 = new Phone("295658813", "iPhone X", 0.3);
                Phone phone2 = new Phone("334850912", "Samsung Galaxy S10");
                Phone phone3 = new Phone();

                Console.WriteLine("Phone 1:");
                Console.WriteLine($"Number: {phone1.getNumber()}");
                phone1.receiveCall("Alex");
                Console.WriteLine();

                Console.WriteLine("Phone 2:");
                Console.WriteLine($"Number: {phone2.getNumber()}");
                phone2.receiveCall("Katarina", "294842910");
                Console.WriteLine();

                Console.WriteLine("Phone 3:");
                Console.WriteLine($"Number: {phone3.getNumber()}");
                phone3.receiveCall("Melissa");
                Console.WriteLine();

                phone1.sendMessage("290908989", "332918374");
                break;

            case 2:
                CreditCard card1 = new CreditCard();
                card1.accountNumber = "1111";
                card1.currentBalance = 0;

                CreditCard card2 = new CreditCard();
                card2.accountNumber = "2222";
                card2.currentBalance = 0;

                CreditCard card3 = new CreditCard();
                card3.accountNumber = "3333";
                card3.currentBalance = 1000;

                card1.AddAmount(500);
                card2.AddAmount(1000);
                card3.WithdrawAmount(700);

                Console.WriteLine("Information about the card 1:");
                card1.PrintCardInfo();

                Console.WriteLine("\nInformation about the card 2:");
                card2.PrintCardInfo();

                Console.WriteLine("\nInformation about the card 3:");
                card3.PrintCardInfo();
                break;

            case 3:
                ATM atm = new ATM(5, 5, 5);

                atm.AddMoney(2, 3, 4);

                bool success = atm.WithdrawMoney(370);
                if (success)
                {
                    Console.WriteLine("The operation was completed successfully.");
                }
                break;
            case 4:
                Doctor surgeon = new Doctor("Surgeon");
                Doctor dentist = new Doctor("Dentist");
                Doctor therapist = new Doctor("Therapist");

                Patient patient1 = new Patient("Melissa", 1);
                Patient patient2 = new Patient("Katarina", 2);
                Patient patient3 = new Patient("Alex", 3);

                patient1.AssignDoctor(surgeon);
                patient2.AssignDoctor(dentist);
                patient3.AssignDoctor(therapist);
                break;
        }
    }
}
