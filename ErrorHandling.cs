
namespace AssignmentProg1
{
    class ErrorHandling
    {
        public string MessageFailureCode(int failureCode)
        {
            string code = "Something went wrong, contact support with the following error code " + failureCode;

            if (failureCode == 8152)
            {
                code = "Too many characters. ";
            }

            if (failureCode == 18456)
            {
                code = "The login to the database didn't work, try again.";
            }

            if (failureCode == 2627)
            {
                code = "This e-mail is already registered, please try a new one.";
            }

            if (failureCode == 0)
            {
                code = "Connection problems, check your Wi-fi.";
            }

            return code;
        }
    }
}

