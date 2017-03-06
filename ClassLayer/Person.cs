namespace ClassLayer
{
    public class Person
    {
        /// <summary>
        /// Properties for private fields
        /// </summary>
        public string PersonName
        { get; set; }

        public string PersonId
        { get; set; }

        /// <summary>
        /// Declaration of private field members
        /// </summary>
        private string personId;
        private string personName;

        /// <summary>
        /// Constructors
        /// </summary>
        public Person() { }
        public Person(string PersonId, string PersonName)
        {
            this.PersonId = PersonId;
            this.PersonName = PersonName;
        }






    } // end of Person class
}