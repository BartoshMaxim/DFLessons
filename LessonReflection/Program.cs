using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LessonReflection
{
    class Program
    {

        public static void AllData()
        {
            Type type = Type.GetType("LessonReflection.Student");

            var members = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (MemberInfo memberInfo in members)
            {
                Console.WriteLine(memberInfo.Name);
            }
        }

        public static void ChangePrivateField()
        {
            Student student = new Student();

            Type type = student.GetType();

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                if (field.Name == "_temp")
                {
                    var value = field.GetValue(student);
                    Console.WriteLine("Before: {0}", value);

                    field.SetValue(student, 15);

                    value = field.GetValue(student);
                    Console.WriteLine("After: {0}", value);
                }
            }
        }

        public static void ChangePrivateField2()
        {
            Type type = typeof(Student);

            ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
            object student = constructorInfo.Invoke(new object[] { });

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                if (field.Name == "_temp")
                {
                    var value = field.GetValue(student);
                    Console.WriteLine("Before: {0}", value);

                    field.SetValue(student, 15);

                    value = field.GetValue(student);
                    Console.WriteLine("After: {0}", value);
                }
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            Type type = student.GetType();

            var properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var attributes = property.GetCustomAttributes(typeof(MySimpleAttribure), false);

                if (attributes.Length > 0)
                {
                    var attribute = (MySimpleAttribure)attributes[0];
                    Console.WriteLine(property.Name);
                    Console.WriteLine(attribute.Number);
                }
            }
            Console.ReadKey();
        }
    }
}
