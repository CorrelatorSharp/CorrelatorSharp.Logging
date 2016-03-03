using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace CorrelatorSharp.Logging.Tests
{
    [Subject(typeof(LogManager))]
    public class When_creating_a_logger_for_the_current_class
    {
        static TestClass TestClass;
        static ILogger Logger;

        Establish context = () => {
            TestClass = new TestClass();    
        };

        Because of = () => {
            Logger = CreateLogger();
        };

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static ILogger CreateLogger()
        {
            return TestClass.CreateCurrentClassLogger();
        }


        It should_name_the_logger_with_the_class_name = () => {
            Logger.Name.ShouldEqual(typeof(TestClass).FullName);
        };
        

    }

    internal class TestClass
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public ILogger CreateCurrentClassLogger()
        {
            return LogManager.GetCurrentClassLogger();
        }
    }
}
