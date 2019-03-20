using System;
using System.Collections.Generic;

namespace UnitTestesSample.Domain
{
    public class Room
    {
        public Room(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Nome inválido");

            this.Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime Book(
            DateTime startDate, 
            DateTime endDate,
            List<DateTime> books)
        {

            if (books.Contains(startDate))
            {
                throw new Exception("Sala já reservada neste horário");
            }

            return startDate;
        }
    }
}
