using System;
using System.Collections.Generic;

namespace EFCoreSecondLevelCacheInterceptorPG.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}
