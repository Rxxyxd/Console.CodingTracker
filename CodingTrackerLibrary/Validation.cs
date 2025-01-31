﻿namespace CodingTracker
{
    public class Validation
    {
        // Checks if inputted strings are Parseable to DateTime
        public static bool StringToDateTime(string dateStart, string dateEnd)
        {
            bool startIsValid = DateTime.TryParseExact(dateStart, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime startResult);
            bool endIsValid = DateTime.TryParseExact(dateEnd, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime endResult);

            if (endResult > startResult)
                return startIsValid & endIsValid;

            else
                return false;

        }
    }
}
