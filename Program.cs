class program{
    static void Main(string[] args){
        Console.Write("star password :");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("agency :");
        string t = (Console.ReadLine());

        if(b <= 999999 && b >= 0){
            int j = b / 100000 % 10;
            int u = b / 10000 % 10;
            int n = b / 1000 % 10;
            int g = b / 100 % 10;
            int k = b / 10 % 10;
            int o = b % 10;

            if(t == "CIA"){
                if((n >= 6 && n != 8) && (k != 1 && k != 3 && k != 5) && (o % 3 == 0)){
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                }
            }
            if(t == "FBI"){
                if((j >= 4 && j <= 7) && (g % 2 == 0 && g != 6) && (u % 2 == 1)){
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                }
            }
            if(t == "NSA"){
                if((k == 7 || n == 7 || u == 7 || j == 7) && (30 % o == 0) && (g % 3 == 0 && g % 2 != 0)) {
                    Console.WriteLine("True");
                }
                else {
                    Console.WriteLine("False");
                    }
                }
        }
        }
        }