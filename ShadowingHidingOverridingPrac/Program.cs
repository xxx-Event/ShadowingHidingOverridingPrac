using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowingHidingOverridingPrac32
{
    internal class Program
    {
        class Parent
        {
            public int Variable = 273;

            public void Method()
            {
                Console.WriteLine("어흥");
            }

            public virtual void Method2()
            {
                Console.WriteLine("어흥흥");
            }
        }

        class Child : Parent
        {
            public new string Variable = "이칠삼";
            public new void Method()
            {
                Console.WriteLine("야옹");
            }
            public override void Method2()
            {
                Console.WriteLine("야옹야옹");
            }
        }

        // Shadowing 예제
        public static int number = 10;  // 같은 이름의 지역변수에 의해 가려짐(클래스 변수)
        public int number2 = 2;         // 같은 이름의 지역변수에 의해 가려짐(인스턴스 변수)
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);  // 지역변수 number 출력
            Console.WriteLine(Program.number); // 이렇게 접근은 가능

            // 하이딩 예제
            Child child = new Child();
            Console.WriteLine(child.Variable);

            Parent p = child;
            Console.WriteLine(p.Variable);

            child.Method();
            p.Method();

            child.Method2();
            p.Method2();
        }
        void doSomething()
        {
            int number2 = 3;
            Console.WriteLine(number2);
            Console.WriteLine(this.number2); // 인스턴스 변수인 경우는 이렇게.. 
        }
    }
}