namespace ClassLayer
{
    public class Person
    {
        /// <summary>
        /// Declaration of private field members
        /// </summary>
        private string _personId;
        private string _personName;

        public Person(string PersonId, string PersonName)
        {
            this.PersonId = PersonId;
            this.PersonName = PersonName;
        }

        /// <summary>
        /// Properties for private fields
        /// </summary>
        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }


        public string PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }



    } // end of Person class
}