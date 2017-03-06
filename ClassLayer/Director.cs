namespace ClassLayer
{
    public class Director : Person
    {
        /// <summary>
        /// constructor that inherits from the base costructor
        /// </summary>
        /// <param name="PersonId"></param>
        /// <param name="PersonName"></param>
        public Director() { }
        public Director(string PersonId, string PersonName) : base(PersonId, PersonName)
        {
        }
    }
}