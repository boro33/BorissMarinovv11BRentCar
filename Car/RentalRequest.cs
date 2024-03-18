using BorissMarinovv11BRentCar.Client;

namespace BorissMarinovv11BRentCar.Car
{
    public class RentalRequest
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public decimal Price { get; set; }
        public RentalStatus Status { get; set; }
    }
}
