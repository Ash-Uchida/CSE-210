        // We have 4 kinds of loops:
        // while
        string response = "yes";
        while (response == "yes")
        {
            Console.Write("do you want to continue?");
            response = Console.ReadLine();
        }

        // do-while
        // string response;
        do
        {
            Console.Write("Do you want to contine?");
            response = Console.ReadLine();
        } while( response == "yes");

        // for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 2; i <= 20; i = i + 2)
        {
            Console.WriteLine(i);
        }
        // foreach
        List<string> colors = new List<string> { "red", "blue", "yellow" };

        foreach(string color in colors)
        {
            Console.WriteLine(color);
        }

        // random numbers
        Random randomGenerator = new();
        int number = randomGenerator.Next(1, 11);   
        Console.WriteLine(number);