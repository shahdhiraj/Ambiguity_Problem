//Use expliit implementation to remove ambiguity.......
/*@copy right :DKPC2022
*/
namespace _20_Ambiguty;
interface A{
    int add(int a);
}
interface B{
    int add(int a);
}
//MyClass implements both interfaces...
class MyClass : A,B{
    //explicitly implements the two methods()
    int A.add(int a){
        return a+a;
    }
    int B.add(int a){
        return a*a;
    }
    //Call methode () through an interface reference
    public int addA(int a){
        A a_obj ;
        a_obj=this;
        return a_obj.add(a);
    }
    public int addB(int a){
        B b_obj ;
        b_obj=this;
        return b_obj.add(a);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        MyClass ob=new MyClass();
        Console.WriteLine("Calling A.add()");
        Console.WriteLine(ob.addA(5));
        Console.WriteLine("Calling B.add()");
        Console.WriteLine(ob.addB(5));

    }
}
