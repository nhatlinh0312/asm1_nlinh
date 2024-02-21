// Declare a function to process the program
void CalculateWaterBill()
{
    Console.WriteLine("Enter Customer's Name: ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please choose customer type:");
    Console.WriteLine("Enter 1 if you are a household customer, then press enter");
    Console.WriteLine("Enter 2 if you are a public administrative organization, then press enter");
    Console.WriteLine("Enter 3 if you are a manufacturing unit, then press enter");
    Console.WriteLine("Enter 4 if you are a business service, then press enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());

    if (typeCustomer == 1)
    {
        // Household customer
        // Request the number of family members
        Console.WriteLine("Enter the number of family members");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter the water meter reading of the previous month");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the water meter reading of the current month");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());

            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;

                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("The water bill for your household is: {0}", money);
            }
            else
            {
                Console.WriteLine("The water meter reading of the previous month is not greater than that of the current month");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // Public administrative organization customer
        Console.WriteLine("Please enter the water meter reading of the previous month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading of the current month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());

        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("The water bill for the public administrative organization is {0}", m);
        }
        else
        {
            Console.WriteLine("The water meter reading of the previous month is not greater than that of the current month");
        }
    }
    else if (typeCustomer == 3)
    {
        // Manufacturing unit customer
        Console.WriteLine("Please enter the water meter reading of the previous month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading of the current month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());

        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("The water bill for the manufacturing unit is {0}", m);
        }
        else
        {
            Console.WriteLine("The water meter reading of the previous month is not greater than that of the current month");
        }
    }
    else if (typeCustomer == 4)
    {
        // Business service customer
        Console.WriteLine("Please enter the water meter reading of the previous month");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the water meter reading of the current month");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());

        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 22068 * 1.1;
            Console.WriteLine("The water bill for the business service customer is {0}", m);
        }
        else
        {
            Console.WriteLine("The water meter reading of the previous month is not greater than that of the current month");
        }
    }
    else
    {
        Console.WriteLine("Please enter the correct customer type");
    }
}

// Run the program
CalculateWaterBill();
