using Xunit;

namespace DotNetKoans.CSharp
{
    public class AboutNil : Koan
    {
        [Koan(1)]
        public void NilIsNotAnObject()
        {
            Assert.False(typeof(object).IsAssignableFrom(null)); //not everything is an object
        }

        [Koan(2)]
        public void YouGetNullPointerErrorsWhenCallingMethodsOnNil()
        {
            //What is the Exception that is thrown when you call a method on a null object?
            //Don't be confused by the code below. It is using Anonymous Delegates which we will
            //cover later on. 
            object nothing = null;
            Assert.Throws(typeof(System.NullReferenceException), delegate() { nothing.ToString(); });
                /* System.NotSupportedException why was this an answer? */
            //What's the message of the exception? What substring or pattern could you test
            //against in order to have a good idea of what the string is?
            try
            {
                nothing.ToString();
            }
            catch (System.Exception ex)
            {
                Assert.Contains("Object reference" as string, ex.Message);
            }
        }

        [Koan(3)]
        public void CheckingThatAnObjectIsNull()
        {
            object obj = null;
            Assert.True(obj == null);
        }

        [Koan(4)]
        public void ABetterWayToCheckThatAnObjectIsNull()
        {
            object obj = null;
            Assert.Null(obj);
        }

        [Koan(5)]
        public void AWayNotToCheckThatAnObjectIsNull()
        {
            /*
            I'm not sure that I understand the concept that this Koan is trying to teach me.
            Is my solution to this Koan bad practice? If so, why? Why is the solution to the previous Koan better?
            */
            object obj = null;
            Assert.True(obj == null);
            //Assert.True(obj.Equals(null));
        }
    }
}