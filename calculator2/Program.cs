using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

public class Calc{
    public double Sum(double num1, double num2){
        return num1 + num2;
    }
    public double Minus(double num1, double num2){
        return num1 - num2;
    }
    public double Multiply(double num1, double num2){
        return num1 * num2;
    }
    public double Devide(double num1, double num2){
        if (num2 == 0){
            Calc calc = new Calc();
            Requester req = new Requester(calc);
            Console.WriteLine("error:CantDivideByZero");
            req.Req();
        }
        return num1 / num2;
    }
    
    
}
public class Requester{
    Calc calc;
    public Requester(Calc calc){
        this.calc = calc;
    }

    public void Req(){
        bool check = true;

        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        while(check == true){
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите оператор:");
            char oper = Convert.ToChar(Console.ReadLine());
         
            switch(oper){
                case '+':
                Console.WriteLine("Равняется:" + (num1 + num2));  
                break;
                case '-':
                Console.WriteLine("Равняется:" + (num1 - num2));
                break;
                case '*':
                Console.WriteLine("Равняется:" + (num1 * num2));
                break;
                case '/':
                try{
                Console.WriteLine("Равняется:" + (num1 / num2));
                break;
                }
            }
        }
    }
}


    

class Program{
    static void Main(string[] args){
        Calc calc = new Calc();
        Requester req = new Requester(calc);
        req.Req();
    }
}