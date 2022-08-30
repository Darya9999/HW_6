  string b1s = Console.ReadLine();
        int b1 = Convert.ToInt32(b1s);
        string k1s = Console.ReadLine();
        int k1 = Convert.ToInt32(k1s);
        string b2s = Console.ReadLine();
        int b2 = Convert.ToInt32(b2s);
        string k2s = Console.ReadLine();
        int k2 = Convert.ToInt32(k2s);
        double x = (double) (b2 - b1) / (k1 - k2);
        double y = (double) k1 * x + b1;
        string otv = "(" + x + "," + y + ")";

        Console.WriteLine(otv);

