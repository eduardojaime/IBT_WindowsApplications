namespace Lesson05
{
    public class DatabaseHelper
    {
        public virtual bool SendToDatabase(object transaction)
        {
            // add a transaction record to a database
            // create connection object depending on the database technology
            // create transaction object
            // user the transaction object to save it in the database
            return true;
        }

    }
}