// // // using System;
// // // namespace ObjectOriented;
// // // public class Calculator{
// // //     private int _firstValue;
// // //     private int _secondValue;

// // //     private Calculator(){
// // //            Console.WriteLine("welcome to my class");
// // //     }
// // // public  Calculator(int firstValue,int secondValue){
// // // this._firstValue=firstValue;
// // // this._secondValue=secondValue;
// // // }
// // // public int Sum(){
// // //     return _firstValue+_secondValue;
// // // }
// // // public static int  Sum(int firstValue,int secondValue){
// // //     var calculator=new Calculator();
// // //     calculator._firstValue=firstValue;
// // //     calculator._secondValue=secondValue;
// // //     return calculator.Sum();
// // // }
// // // }
// // // internal class Program
// // // {
// // //     private static void Main()
// // //     {
// // //         var firstValue=int.Parse(Console.ReadLine());
// // //         var secondValue=int.Parse(Console.ReadLine());
// // //         var calculator=new Calculator(firstValue,secondValue);
// // //       Console.WriteLine("this sum "+calculator.Sum());
// // //             Console.WriteLine("this sum "+Calculator.Sum(firstValue,secondValue));

// // //     }
// // // }


// // using System;
// // namespace reham;
// // public abstract class Car{
// //     public string Name;
// //     public string Color;
// //     public Car(){

// //     }
// //     public Car(string name,string color){
// //         Name=name;
// //         Color=color;
// //     }
// //     public virtual void print(){
// //         Console.WriteLine($"name is {Name} color is {Color}");
// //     }

// //     public abstract void start();
// // }
// // public abstract class Electric_car : Car{
// //     public int Battery;

// //     public Electric_car(string name,string color,int battery){
// //          Name=name;
// //         Color=color;
// //         Battery=battery;
// //     }
// //     public void A(){
// //         print();
// //     }
    

// //      public override void print(){
// //         base.print();
// //         Console.WriteLine($" Battery {Battery}");
// //     }
// // }
// // public class Tesla:Electric_car{
// //     public Tesla(string name,string color,int battery):base(name,color,100){
        
// //     }
// //     public override void start(){
// //           Console.Write("tesla");
// //     }
// // }
// // public class reham{
// //     private static void Main(){
// //         Console.Write("enter name : ");
// //         var name=Console.ReadLine();
// //         Console.Write("enter color : ");
// //         var color=Console.ReadLine();
// //         var obj=new Tesla(name,color,100);
// //         obj.print();
// //     }
// // }


// using System;
// namespace reham;

// public class person{
//     public virtual void i_am(){
//         Console.WriteLine("i am a person");
//     }
// }
// public class employye:person{
// public override void i_am(){
//         Console.WriteLine("i am a employee");
//     }
// }
// public class customer:person{
//     public override void i_am(){
//         Console.WriteLine("i am a customer");
//     }
// }
// public class reham{
//     private static void Main(){
// person p=new person();
// employye e=new employye();
// customer c=new customer();
// p.i_am();
// e.i_am();
// c.i_am();
//     }
// }


using System;
namespace reham;


public abstract class Person{
    public string Name;
    public int Age;
   public  Person(string name,int age){
    Name=name;
    Age=age;
   }
  
    public abstract  void print();
}
public class Students:Person{
    public int Year;
    public float Gpa;
    public Students(string name,int age,int year,float gpa):base(name,age){
          Year=year;
          Gpa=gpa;
    }
     public override void print(){
           Console.WriteLine($"my name is {Name} and my age is {Age} gpa with {Gpa} years is {Year}");
     }
}

public class Database{
   
    public int current_index=0;
    public Person[] People=new Person[50];
    public void addstudent(Students student){
    People[current_index++]=student;
    Console.WriteLine("add student");
    }
    public void addstaff(Staff staff){
    People[current_index++]=staff;
    Console.WriteLine("add staff");
    }
}
public class Staff:Person{
    public double Salary;
    public int JoinYear;
    public Staff(string name,int age ,double salary,int joinyear):base(name,age){
         Salary=salary;
         JoinYear=joinyear;
    }
    public override void print(){
        Console.WriteLine($"My name is {Name} my age is {Age} and my salary{Salary} ");
    }
}
public class reham{
    private static void Main(){
    Console.Write("option : ");
    int option=int.Parse(Console.ReadLine());
    var obj=new Database();
    Console.Write("Name : ");
    var name=Console.ReadLine();
    Console.Write("Age : ");
    var age=Convert.ToInt32(Console.ReadLine());
    Console.Write("Year : ");
    var year=Convert.ToInt32(Console.ReadLine());
    Console.Write("Gpa : ");
    float gpa=Convert.ToSingle(Console.ReadLine());;
    Console.Write("salary : ");
    double salary=Double.Parse(Console.ReadLine());
    salary=(double) salary;
    Console.Write("joinyear : ");
    var joinyear=Convert.ToInt32(Console.ReadLine());
    var student=new Students(name,age,year,gpa);
    var staff=new Staff(name,age,salary,joinyear);
    switch (option){
        case 1:
        obj.addstaff(staff);
        break;
        case 2:
        obj.addstudent(student);
        break;
        default:
        for(int i=0;i<obj.current_index;i++){
            Console.Write(obj.People[i]);
        }
        break;
    }
    }
}
