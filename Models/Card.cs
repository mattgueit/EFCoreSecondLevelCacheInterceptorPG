namespace EFCoreSecondLevelCacheInterceptorPG.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public int PlayerId { get; set; }
        public int Overall { get; set; }
        public int Pace { get; set; }
        public int Shooting { get; set; }
        public int Passing { get; set; }
        public int Dribbling { get; set; }
        public int Defending { get; set; }
        public int Physical { get; set; }

        public Player Player { get; set; }
    }
}