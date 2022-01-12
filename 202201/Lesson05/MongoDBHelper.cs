namespace Lesson05
{
    public class MongoDbHelper : DatabaseHelper
    {
        public override bool SendToDatabase(object transaction)
        {
            // Using connector 3.6.1, version 4.0.1 does not support our business need
            // add a transaction record to a MONGO DB SPECIFIC database
            // create connection object depending on the database technology
            // create transaction object
            // user the transaction object to save it in the database
            return true;
        }

    }
}