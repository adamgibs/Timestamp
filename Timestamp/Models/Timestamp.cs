using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timestamp.Models
{
    public class Timestamp
    {
        public DateTime Date { get; set; }
        public long UnixTimestamp { get; set; }

        public long GetUnixTimestamp(DateTime date)
        {
            
            var dateTimeOffset = new DateTimeOffset(date);
            var unixDateTime = dateTimeOffset.ToUnixTimeSeconds();



            return unixDateTime;
        }

        public String GetDate(long unixTime)
        {
            
            DateTime localDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTime)
                                        .DateTime.ToLocalTime();

            return localDateTimeOffset.Date.ToString("d");
        }
    }
}
