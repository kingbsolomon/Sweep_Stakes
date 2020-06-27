﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public Contestant(string firstName, string lastName, string emailAddress,
            int registrationNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            RegistrationNumber = registrationNumber;
        }

        public string[] SplitContestantString(string contestantInfo)
        {
            string[] constestantInfoString = contestantInfo.Split(',');
            return constestantInfoString;
        }
    }
}
