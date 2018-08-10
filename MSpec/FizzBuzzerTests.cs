using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSpec
{
    public class FizzBuzzerTests
    {
        [Subject(typeof(FizzBuzzer))]
        public class when_given_number_not_divisible_by_five_and_three
        {
            //Arrange
            Establish context = () => { Subject = new FizzBuzzer(); };

            //Act   
            Because of = () => Actual = Subject.FizzBuzz(1);

             //Assert
            It should_return_those_numbers = () =>
                Actual.ShouldEqual("1").ToString();
        }

        [Subject(typeof(FizzBuzzer))]
        public class when_given_number_divisible_by_three
        {
            //Arrange
            Establish context = () => { Subject = new FizzBuzzer(); };

            //Act   
            Because of = () => Actual = Subject.FizzBuzz(3);

            //Assert
            It should_return_fizz = () =>
                Actual.ShouldEqual("Fizz").ToString();
        }

        [Subject(typeof(FizzBuzzer))]
        public class when_given_number_divisible_by_five
        {
            //Arrange
            Establish context = () => { Subject = new FizzBuzzer(); };

            //Act   
            Because of = () => Actual = Subject.FizzBuzz(5);

            //Assert
            It should_return_buzz = () =>
                 Actual.ShouldEqual("Buzz").ToString();
        }

        [Subject("given number divisible by both three and five")]
        public class when_given_number_divisible_by_five_and_three
        {
            //Arrange
            Establish context = () => { Subject = new FizzBuzzer(); };

            //Act   
            Because of = () => Actual = Subject.FizzBuzz(15);

            //Assert
            It should_return_fizzbuzz = () =>
                 Actual.ShouldEqual("FizzBuzz").ToString();
        }

        static string Actual;
        static FizzBuzzer Subject;
    }
}
