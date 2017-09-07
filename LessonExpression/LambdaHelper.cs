using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LessonExpression
{
    class LambdaHelper
    {
        static void LambdaExpression()
        {
            Func<int, int, int> lambda = (x, y) => (x + y) * 2;
            //Console.WriteLine(lambda(5, 4));

            ParameterExpression xParam = Expression.Parameter(typeof(int), "x");
            ParameterExpression yParam = Expression.Parameter(typeof(int), "y");

            ConstantExpression constant = Expression.Constant(2);

            Expression sum = Expression.Add(xParam, yParam);
            Expression mult = Expression.Multiply(sum, constant);

            LambdaExpression lambdaExpression = Expression.Lambda(mult, xParam, yParam);

            var newLambda = (Func<int, int, int>)lambdaExpression.Compile();

            //Console.WriteLine(newLambda(5, 4));

            Console.ReadLine();
        }
    }
}
