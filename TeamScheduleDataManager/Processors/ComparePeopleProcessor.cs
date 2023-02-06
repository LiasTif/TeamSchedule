using System;
using TeamScheduleApp.Models;

namespace TeamScheduleDataManager.Processors
{
    /// <summary>
    /// Class with compare people functional
    /// </summary>
    public class ComparePeopleProcessor
    {
        /// <summary>
        /// Compare two persons and return boolean
        /// </summary>
        /// <param name="firstPerson"></param>
        /// <param name="secondPerson"></param>
        /// <returns>is people same?</returns>
        public bool Compare(Person firstPerson, Person secondPerson)
        {
            return firstPerson.Id == secondPerson.Id &&
                EqualCheck(firstPerson.FName, secondPerson.FName) &&
                EqualCheck(firstPerson.LName, secondPerson.LName) &&
                EqualCheck(firstPerson.PinCode, secondPerson.PinCode);
        }

        /// <summary>
        /// Use StringComparison to compare stings
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        private bool EqualCheck(string firstString, string secondString)
        {
            return string.Equals(firstString, secondString, StringComparison.Ordinal);
        }
    }
}