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


public  class Person{
    private string _name;
    private int _age;
    public  Person(string name,int age){
        if(name==null || name.Length==0 || name.Length>=32){
        //    ارمي اكسبشن عشان البرنامج يقف - يوصل لاخر ال main
           throw new Exception("invalid name");
        }
        if(age<=0 || age>128){
            // this
            // var exe=new Exception();
            // throw exe;
            // or this
          throw new Exception("invalid age");
        } 
        _name=name;
        _age=age;
    }
       public string GetName()=>_name;
       public int GetAge()=>_age;
       public void SetName(string name){
         if(name==null || name.Length==0 || name.Length>=32){
        //    ارمي اكسبشن عشان البرنامج يقف - يوصل لاخر ال main
           throw new Exception("invalid name");
        }
        _name=name;
       }
       public void SetAge(int age){
        if(age<=0 || age>128){
          throw new Exception("invalid age");
        } 
        _age=age;
       }
    public  virtual void Print(){
       Console.WriteLine($"name is {_name} age is {_age}");
    }
}


public class Students:Person{
    public int Year;
    public float Gpa;
    public Students(string name,int age,int year,float gpa):base(name,age){
        if(year<1 || year>5){
            throw new Exception("invalid year");
        }
        if(gpa <=0||gpa>4){
             throw new Exception("invalid gpa");
        }
          Year=year;
          Gpa=gpa;
    }
     public override void Print(){
           Console.WriteLine($"my name is {GetName()} and my age is {GetAge()} gpa with {Gpa} years is {Year}");
     }
}

public class Staff:Person{
    public double Salary;
    public int JoinYear;
    public Staff(string name,int age ,double salary,int joinyear):base(name,age){
       if(salary<=0 || salary >120000 ){
        throw new Exception("invalid salary");
       }
        DateTime today = DateTime.Today;
        int year = DateTime.Today.Year-GetAge();
       if(joinyear-year<21){
        throw new Exception("invalid join year");
       }
       
         Salary=salary;
         JoinYear=joinyear;
    }
    public override void Print(){
        Console.WriteLine($"My name is {GetName()} my age is {GetAge()} and my salary {Salary} ");
    }
}

public class Database{
    public int current_index=0;
    public Person[] People=new Person[50];
    public void addstudent(Students student){
    People[current_index++]=student;
    }
    public void addstaff(Staff staff){
    People[current_index++]=staff;
    }
    public void addperson(Person person){
         People[current_index++]=person;
    }
    public void PrintAll(){
        for(int i=0;i<current_index;i++){
            People[i].Print();
        }
        // foreach(var item in People){
            // if null -not instance
        //     item?.Print();
        // }
    }
}

public class reham{
    private static void Main(){
       
    var obj=new Database();
    while(true){
    Console.WriteLine("1) student 2)staff 3)person 4)print all ");
    Console.Write("option : ");
    int option=int.Parse(Console.ReadLine());
    switch (option){
        case 1:
        Console.Write("Name : ");
        var names=Console.ReadLine();
        Console.Write("Age : ");
        var ages=Convert.ToInt32(Console.ReadLine());
        Console.Write("Year : ");
        var year=Convert.ToInt32(Console.ReadLine());
        Console.Write("Gpa : ");
        float gpa=Convert.ToSingle(Console.ReadLine());
        try{
             var student=new Students(names,ages,year,gpa);
             obj.addstudent(student);
        }catch(Exception e){
             Console.WriteLine(e.Message);
        }
        break;
        case 2:
        Console.Write("Name : ");
        var name=Console.ReadLine();
         Console.Write("Age : ");
        var age=Convert.ToInt32(Console.ReadLine());
        Console.Write("salary : ");
        double salary=Double.Parse(Console.ReadLine());
        Console.Write("joinyear : ");
        var joinyear=Convert.ToInt32(Console.ReadLine());

        try{
            var staff=new Staff(name,age,salary,joinyear);
            obj.addstaff(staff); 
        }catch(Exception e){
              Console.WriteLine(e.Message);
        }
        
        break;
        case 3:
        Console.Write("Name : ");
        var name3=Console.ReadLine();
        Console.Write("Age : ");
        var age3=Convert.ToInt32(Console.ReadLine());
         try{
            var person=new Person(name3,age3);
            obj.addperson(person);
         }catch(Exception ex){
           Console.WriteLine(ex.Message);
         }
        break;
        default:
        obj.PrintAll();
        break;
    }
    }
    Console.WriteLine("welcome");
    }
}
