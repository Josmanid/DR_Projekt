namespace DR_Projekt.Models
{
    public class MusicRecord
    {
        //Her gemmer vi
        private string? _title;
        private int _duration;
        private string? _artist;
        private int _year;

        // Her er vores filter
        public string Title
        {
            get => _title;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Hov du glemte at skrive en kunstner?!");

                }
                 if ( value.Length < 2)
                 { 
                    throw new ArgumentOutOfRangeException("Titel skal have mindst 2 bogstavere ");
                 }
                     
                _title = value;
            }

        }

        public override string ToString() {
            return $"{Title}";
        }
    }
}
