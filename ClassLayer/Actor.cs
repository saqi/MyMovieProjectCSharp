namespace ClassLayer
{
    public class Actor : Person
    {
        /// <summary>
        /// constructor that inherits from the base costructor
        /// </summary>
        /// <param name="PersonId"></param>
        /// <param name="PersonName"></param>
        public Actor(string PersonId, string PersonName) : base(PersonId, PersonName)
        {
        }
    }
}