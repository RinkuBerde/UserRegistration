using UserRegistration;
using static System.Net.Mime.MediaTypeNames;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //declaration of variable regexValidation of RegexValidation class
        Validate regexValidation;

        [TestInitialize]
        public void InitValidationObj()
        {
            //Arrange -- initialise the object to compare/test
            regexValidation = new Validate();
        }

        [TestMethod]
        public void FirstNameTest_ShouldReturnTrue()
        {
            //Arrange -- declare a firstName string variable 
            string firstName = "Rinku";

            //Act -- basic logical construct for testing
            var FirstName = regexValidation.ValidateFirstName(firstName);

            //Assert --  test comparison with the standard values
            Assert.IsTrue(FirstName);

        }
        //Method to test lastname function in user registration project
        [TestMethod]
        public void LastNameTest_ShouldReturnTrue()
        {
            //Arrange -- declare a lastName string variable 
            string lastName = "Berde";

            //Act
            var LastName = regexValidation.ValidateLastName(lastName);

            //Assert
            Assert.IsTrue(LastName);

        }
        //Method to test Email function in user registration project
        [TestMethod]
        public void EmailTest_ShouldReturnTrue()
        {
            //Arrange -- declare an email string variable 
            string email = "rinku.berde@fake.co.in";

            //Act
            var Email = regexValidation.ValidateEmail(email);

            //Assert
            Assert.IsTrue(Email);

        }
        //ValidatePhone
        [TestMethod]
        public void PhoneNumberTest_ShouldReturnTrue()
        {
            //Arrange -- declare a number string variable 
            string number = "91 1234567890";

            //Act
            var PhoneNumber = regexValidation.ValidateMobile(number);

            //Assert
            Assert.IsTrue(PhoneNumber);

        }
        //Validate Password
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue()
        {
            //Arrange -- declare a passW string variable 
            string passW = "rinkuA1@rq";

            //Act
            var password = regexValidation.ValidatePassword1(passW);

            //Assert
            Assert.IsTrue(password);
        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue2()
        {
            //Arrange -- declare a passW string variable 
            string passW = "rinkuA1r@q";

            //Act
            var password = regexValidation.ValidatePassword2(passW);

            //Assert
            Assert.IsTrue(password);

        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue3()
        {
            //Arrange -- declare a passW string variable 
            string passW = "rinkuAr@q";

            //Act
            var password = regexValidation.ValidatePassword3(passW);

            //Assert
            Assert.IsTrue(password);
        }
        [TestMethod]
        public void PasswordTest_ShouldReturnTrue4()
        {
            //Arrange -- declare a passW string variable 
            string passW = "rinkuA1r@q";

            //Act
            var password = regexValidation.ValidatePassword4(passW);

            //Assert
            Assert.IsTrue(password);
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", "abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        public void Email(string a, string expected)
        {
            Validate validate = new Validate();

            string actual = validate.Email(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenUserFistName_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a firstName string variable 
                string firstName = "rinku";

                //Act
                bool FirstName = regexValidation.ValidateFirstName(firstName);
            }
            catch (ValidationExceptions e)
            {
                //Assert
                Assert.AreEqual("Invalid First Name", e.Message);

            }
        }

        [TestMethod]
        public void GivenUserLastName_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a lastName string variable 
                string lastName = "berde";

                //Act
                bool LastName = regexValidation.ValidateFirstName(lastName);
            }
            catch (ValidationExceptions e)
            {

                //Assert
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmailId_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare an email string variable 
                string email = "berde.rinku.com";

                //Act
                bool Email = regexValidation.ValidateEmail(email);
            }
            catch (ValidationExceptions e)
            {
                //Assert
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }

        [TestMethod]
        public void GivenMobileNumber_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a number string variable 
                string number = "91 0863053941";

                //Act
                bool PhoneNumber = regexValidation.ValidateMobile(number);

            }
            catch (ValidationExceptions e)
            {
                //Assert
                Assert.AreEqual("Invalid Phone Number", e.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_OnValidation_ShouldThrowCustomException()
        {
            try
            {
                //Arrange -- declare a password string variable 
                string password = "rinku1r@q";

                //Act
                bool Password = regexValidation.ValidatePassword4(password);

            }
            catch (ValidationExceptions e)
            {
                //Assert
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }
    }
}
