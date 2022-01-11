using System;

namespace Lesson05
{
    public class Cab 
    {
	    public Cab (string serialNumber) {
    	    SerialNumber = serialNumber;
	    }
        //The property is public to get, but private to set
        public string SerialNumber { get; private set; }
    }
}