namespace SampleMVCApplication.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public string TitleOfContainer { get; set; }
        public decimal Price { get; set; }
        public string PlaceOfPublication { get; set; }
        public DateOnly publicationDate { get; set; }
        public int PageCount { get; set; }


        public string MLAStyleCitation
        {
            get
            {
                return AuthorLastName + "," + AuthorFirstName + "." + Title + "," + TitleOfContainer + "," + Publisher + "," + publicationDate + ", PP - " + PageCount + ".";
            }
        }

        public string ChicagoStyleCitation
        {
            get
            {
                return AuthorLastName + "," + AuthorFirstName + "." + Title + "," + PlaceOfPublication + "," + Publisher + "," + publicationDate + ".";
            }
        }
    }
}
