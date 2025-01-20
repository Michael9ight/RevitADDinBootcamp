namespace RevitADDinBootcamp
{
    [Transaction(TransactionMode.Manual)]
    public class cmdSkills01 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {


            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            // let's create some variables
            // DataType VariableName = Value; <-always end the line with a semicolon!

            // create string variables
            String text1 = "this is my text";
            String text2 = "this is my next text";

            // combine strings
            String text3 = text1 + text2;
            String text4 = text1 + "" + text2;

            // create number variables
            int number1 = 10;
            double number2 = 20.5;

            // do some math
            double number3 = number1 + number2;
            double number4 = number1 - number2;
            double number5 = number4 / number3;
            double number6 = number5 * number4;

            // convert meters to feet
            double meters = 4;
            double metersToFeet = meters * 3.2804;

            // convert mm to feet
            double mm = 3500;
            double mmToFeet = mm / 304.8;
            double mmToFeet2 = (mm / 1000) * 3.28084;

            // find the remainder when dividing (ie. the modulo or mod)
            double remainder1 = 100 % 10; // equals 0 (100 dived by 10 +10)
            double remainder2 = 100 % 10; // equals 1 (100 divided by 9 = 11 with remainder

            // increment anumber by 1
            number6++;
            number6--;

            // use conditional logic to compare things
            // compare using boolean operators
            //== equals
            //!= not equal
            //> greater than
            //< less than
            //>= and <=

            // check a value and perform a single action if true
            if (number6 > 10)
            {
                // do something if true
            }

            // check a value if and perform an action if true and another action if false
            if (number5 == 100)
            {
                // do something if false
            }
            else
            {
                // do something if False
            }

            // check multiple values and perform actions if true and false
            if (number6 > 10)
            {
                // do something if true
            }
            else if (number6 == 8)
            {
                // do something else if true
            }
            else if (number6 == 5)
            {
                // do something else if true
            }
            else
            {
                // do a third thing
            }

            // compound conditional statement
            // look for two things (or more) using &&
            if (number6 > 10 && number5 == 100)
            {
                // do something both are true
            }

            // look for  either thing using ||
            if (number6 > 10 || number5 == 100)
            {
                //do something if either is true
            }


            // create a list
            List<string> list1 = new List<string>();

            // add items to the list
            list1.Add(text1);
            list1.Add(text2);
            list1.Add("this is new text for my list");

            List<int> list2 = new List<int> { 1, 2, 3, 4, 5 };
            List<string> list3 = new List<string> { "one", "two", "three", "four" };

            // loop through items in a list using a foreach loop
            foreach (string currentString in list1)
            {
                // do something with current string
            }

            int letterCount = 0;
            foreach(string currentString in list1)
            {
                letterCount = letterCount + currentString.Length;
            }

            // loop through a range of numbers
            for(int i = 0; i <=10; i++)
            {
                   // do something

            }

            // loop through a range of variable numbers
            int numberCount = 0;
            int counter = 100;
            for(int i = 0; i <=counter; i++)
            {
                numbercount
            }

            return Result.Succeeded;
        }
    }

}
