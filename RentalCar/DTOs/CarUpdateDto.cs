namespace RentalCar.DTOs
{
    public class CarUpdateDto
    {
        public string Brand { get; set; } = string.Empty;
        public string PlaceId { get; set; } = string.Empty;
        public decimal KmInitial { get; set; }
        public decimal KmFinal { get; set; }
        public bool IsRended { get; set; }
    }
}
