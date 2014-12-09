namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }
        public int ResttaurantId { get; set; }
    }
}