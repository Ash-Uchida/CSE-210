// A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "";
        public string _familyName = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }

        // ----------------------------------------------------------------
        person1 = new Person();
        person1._givenName = "Emma";
        person1._familyName = "Smith";
        person1.ShowWesternName();

        person2 = new Person();
        person2._givenName = "Joseph";
        person2._familyName = "Smith";
        person2.ShowWesternName();

        // the output is this:
        // Emma Smith
        // Joseph Smith
        // ----------------------------------------------------------------
        
    
    }