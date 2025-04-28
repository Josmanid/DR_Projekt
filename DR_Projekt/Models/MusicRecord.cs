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
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Titel skal have mindst 2 bogstavere ");
                }

                _title = value;
            }

        }
        public int Duration
        {
            get => _duration;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("you can not go back in time");
                }
                _duration = value;
            }
        }

        public int Year
        {
            get => _year;

            set
            {
                if (value < 1940)
                {
                    throw new ArgumentOutOfRangeException("This is too ancient");
                }
                _year = value;
            }
        }

        public override string ToString() {
            return $"{Title}";
        }
    }
}
